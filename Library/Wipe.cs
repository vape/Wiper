using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Wiper.Library
{
    public static class Wipe
    {
        const int bufferSize = 4096;

        public static void WipeFile(FileInfo fileInfo, int passesCount = 1,
            Action<WipeProgress> progressChangedCallback = null,
            CancellationToken? cancellationToken = null)
        {
            if (fileInfo == null)
                throw new ArgumentNullException(nameof(fileInfo));
            if (passesCount < 1)
                throw new ArgumentOutOfRangeException(nameof(passesCount));

            if (!fileInfo.Exists)
                throw new FileNotFoundException("File not exists.", fileInfo.FullName);

            try
            {
                fileInfo.IsReadOnly = false;
            }
            catch (ArgumentException)
            {
                throw new UnauthorizedAccessException("Cannot change ReadOnly flag.");
            }

            using (var fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                var buffer = new byte[bufferSize];
                var random = RNGCryptoServiceProvider.Create();

                for (int i = 0; i < passesCount; ++i)
                {
                    fileStream.Position = 0;

                    while (fileStream.Position < fileStream.Length)
                    {
                        if (cancellationToken != null)
                            cancellationToken.Value.ThrowIfCancellationRequested();
                        if (progressChangedCallback != null)
                            progressChangedCallback(new WipeProgress(fileStream.Position + (i * fileStream.Length), fileStream.Length * passesCount));

                        random.GetBytes(buffer);
                        fileStream.Write(buffer, 0, buffer.Length);
                    }

                    progressChangedCallback(new WipeProgress(fileStream.Length * passesCount, fileStream.Length * passesCount));
                }

                fileStream.SetLength(0);
            }

            fileInfo.Delete();
        }
    }
}
