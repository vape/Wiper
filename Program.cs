using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

using Wiper.Library;
using Wiper.Properties;

namespace Wiper
{
    static class Program
    {
        public static bool ContextOptionEnabled
        {
            get { return Registry.ClassesRoot.OpenSubKey(command) != null; }
        }

        public static bool HasAdminPrivelegies
        {
            get
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private static string option = $"*\\shell\\wiper";
        private static string command = $"{option}\\command";

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && File.Exists(args[0]))
            {
                if (Dialogs.Question(Resources.Program_Confirmation, Resources.Program_ConfirmationVerbose) == DialogResult.No)
                    return;

                WipeFile(args[0]);
                Application.Run();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        public static void EnableContextOption()
        {
            if (ContextOptionEnabled || !HasAdminPrivelegies)
                return;

            Registry.ClassesRoot.CreateSubKey(option, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("", Resources.Program_ContextCommandText);
            Registry.ClassesRoot.CreateSubKey(command, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("", $"{Assembly.GetExecutingAssembly().Location} \"%1\"");
        }

        public static void DisableContextOption()
        {
            if (!ContextOptionEnabled || !HasAdminPrivelegies)
                return;

            Registry.ClassesRoot.DeleteSubKeyTree(option);
        }

        public static void RestartAsAdmin(string arguments)
        {
            bool exit = true;

            var info = new ProcessStartInfo(Assembly.GetExecutingAssembly().Location) { Verb = "runas", Arguments = arguments };
            var prcs = new Process() { StartInfo = info };

            try
            {
                prcs.Start();
            }
            catch (Exception)
            {
                exit = false;
            }
            finally
            {
                if (exit)
                    Application.Exit();
            }
        }

        private async static void WipeFile(string fileName)
        {
            var progressDialog = Dialogs.ProgressDialog(Resources.Program_WipingTitle, fileName);

            try
            {
                var tokenSource = new CancellationTokenSource();
                progressDialog.FormClosing += (sender, e) => 
                    tokenSource.Cancel();
                Action<WipeProgress> progressChangedCallback = (x) => 
                    progressDialog.UpdateProgress(x.PercentProgress);
                progressDialog.Show();

                await Task.Run(() => Wipe.WipeFile(new FileInfo(fileName), Settings.Default.PassesCount, progressChangedCallback, tokenSource.Token));
                Dialogs.Info(Resources.Program_OperationCompleted, Resources.Program_OperationCompletedVerbose);
            }
            catch (UnauthorizedAccessException)
            {
                if (!HasAdminPrivelegies)
                    RestartAsAdmin($"\"{fileName}\"");
                else
                    Dialogs.Error(Resources.Program_AccessError);
            }
            catch (OperationCanceledException)
            {
                Dialogs.Info(Resources.Program_OperationCancelled, Resources.Program_OperationCancelledVerbose);
            }
            catch (Exception e)
            {
                Dialogs.Error(e);
            }
            finally
            {
                progressDialog.Close();

                Application.Exit();
            }
        }
    }
}