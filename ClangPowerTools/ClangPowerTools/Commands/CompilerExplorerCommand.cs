using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ClangPowerTools.Output;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace ClangPowerTools.Commands
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CompilerExplorerCommand : ClangCommand
    {
        #region Properties
        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CompilerExplorerCommand Instance
        {
            get;
            private set;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CompilerExplorerCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private CompilerExplorerCommand(OleMenuCommandService aCommandService, CommandsController aCommandsController, ErrorWindowController aErrorWindow, 
            OutputWindowController aOutputWindow, AsyncPackage aPackage, Guid aGuid, int aId)
            : base(aCommandsController, aErrorWindow, aOutputWindow, aPackage, aGuid, aId)
        {
            if (null != aCommandService)
            {
                CommandID menuCommandID = new CommandID(CommandSet, Id);
                OleMenuCommand menuCommand = new OleMenuCommand(mCommandsController.Execute, menuCommandID);
                menuCommand.BeforeQueryStatus += mCommandsController.OnBeforeClangCommand;
                menuCommand.Enabled = true;
                aCommandService.AddCommand(menuCommand);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static async System.Threading.Tasks.Task InitializeAsync(CommandsController aCommandsController,
          ErrorWindowController aErrorWindow, OutputWindowController aOutputWindow, AsyncPackage aPackage, Guid aGuid, int aId)
        {
            // Switch to the main thread - the call to AddCommand in Command1's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(aPackage.DisposalToken);

            OleMenuCommandService commandService = await aPackage.GetServiceAsync((typeof(IMenuCommandService))) as OleMenuCommandService;
            Instance = new CompilerExplorerCommand(commandService, aCommandsController, aErrorWindow, aOutputWindow, aPackage, aGuid, aId);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        public void RunCompilerExplorer(int aCommandId)
        {
            MessageBox.Show("Hello World");
        }

        #endregion;
    }
}
