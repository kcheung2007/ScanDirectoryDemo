using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Text;
using System.Data;

namespace ScanDirectoryDemo
{
	/// <summary>
	/// Summary description for ScanDirectoryDemo
	/// </summary>
	public class ScanDirectoryDemoForm : System.Windows.Forms.Form
	{
		private TreeNode _currentNode;

		#region Form controls

		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel panelText;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TreeView directoryTree;
		private System.Windows.Forms.Panel panelActions;
		private System.Windows.Forms.GroupBox groupTree;
		private System.Windows.Forms.Label labelScan;
		private System.Windows.Forms.TextBox textDirectory;

		#endregion
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.Label labelSearch;



		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// 
		/// </summary>
		public ScanDirectoryDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.panelText = new System.Windows.Forms.StatusBarPanel();
			this.panelActions = new System.Windows.Forms.Panel();
			this.textDirectory = new System.Windows.Forms.TextBox();
			this.labelScan = new System.Windows.Forms.Label();
			this.groupTree = new System.Windows.Forms.GroupBox();
			this.directoryTree = new System.Windows.Forms.TreeView();
			this.textSearch = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.panelText)).BeginInit();
			this.panelActions.SuspendLayout();
			this.groupTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.Location = new System.Drawing.Point(384, 8);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(184, 32);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Use events";
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(384, 48);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(184, 32);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 360);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.panelText});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(584, 22);
			this.statusBar1.TabIndex = 4;
			this.statusBar1.Text = "statusBar1";
			// 
			// panelText
			// 
			this.panelText.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.panelText.Width = 568;
			// 
			// panelActions
			// 
			this.panelActions.Controls.Add(this.textSearch);
			this.panelActions.Controls.Add(this.labelSearch);
			this.panelActions.Controls.Add(this.textDirectory);
			this.panelActions.Controls.Add(this.labelScan);
			this.panelActions.Controls.Add(this.buttonStart);
			this.panelActions.Controls.Add(this.buttonCancel);
			this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelActions.Location = new System.Drawing.Point(0, 0);
			this.panelActions.Name = "panelActions";
			this.panelActions.Size = new System.Drawing.Size(584, 88);
			this.panelActions.TabIndex = 6;
			// 
			// textDirectory
			// 
			this.textDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textDirectory.Location = new System.Drawing.Point(120, 8);
			this.textDirectory.Name = "textDirectory";
			this.textDirectory.Size = new System.Drawing.Size(248, 20);
			this.textDirectory.TabIndex = 4;
			this.textDirectory.Text = "C:\\";
			// 
			// labelScan
			// 
			this.labelScan.Location = new System.Drawing.Point(8, 8);
			this.labelScan.Name = "labelScan";
			this.labelScan.Size = new System.Drawing.Size(104, 20);
			this.labelScan.TabIndex = 3;
			this.labelScan.Text = "Scan directory";
			this.labelScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupTree
			// 
			this.groupTree.Controls.Add(this.directoryTree);
			this.groupTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupTree.Location = new System.Drawing.Point(0, 88);
			this.groupTree.Name = "groupTree";
			this.groupTree.Size = new System.Drawing.Size(584, 272);
			this.groupTree.TabIndex = 7;
			this.groupTree.TabStop = false;
			this.groupTree.Text = "Directory tree";
			// 
			// directoryTree
			// 
			this.directoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.directoryTree.ImageIndex = -1;
			this.directoryTree.Location = new System.Drawing.Point(8, 16);
			this.directoryTree.Name = "directoryTree";
			this.directoryTree.SelectedImageIndex = -1;
			this.directoryTree.Size = new System.Drawing.Size(568, 248);
			this.directoryTree.TabIndex = 4;
			// 
			// textSearch
			// 
			this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textSearch.Location = new System.Drawing.Point(120, 32);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(248, 20);
			this.textSearch.TabIndex = 6;
			this.textSearch.Text = "*.*";
			// 
			// labelSearch
			// 
			this.labelSearch.Location = new System.Drawing.Point(8, 32);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(104, 20);
			this.labelSearch.TabIndex = 5;
			this.labelSearch.Text = "Search pattern";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ScanDirectoryDemoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 382);
			this.Controls.Add(this.groupTree);
			this.Controls.Add(this.panelActions);
			this.Controls.Add(this.statusBar1);
			this.Name = "ScanDirectoryDemoForm";
			this.Text = "Test ScanDirectory class";
			((System.ComponentModel.ISupportInitialize)(this.panelText)).EndInit();
			this.panelActions.ResumeLayout(false);
			this.groupTree.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ScanDirectoryDemoForm());
		}

		/// <summary>
		/// Handles the Click event of the buttonStart control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Enable the cancel button
				buttonCancel.Enabled = true;			

				// Disable the start button
				buttonStart.Enabled = false;

				// Clear the nodes in the tree control
				directoryTree.Nodes.Clear();
	
				// Clear the current node reference
				_currentNode = null;

				this.ScanTheDirectories(textDirectory.Text);
			}
			catch (Exception ex)
			{
				panelText.Text = ex.Message;
			}
			finally
			{
				buttonStart.Enabled = true;
				buttonCancel.Enabled = false;
			}

			// Create a new ScanDictory object
			ScanDirectory scanDirectory = new ScanDirectory();

			// Add a DirectoryEvent to the class
			scanDirectory.DirectoryEvent += new ScanDirectory.DirectoryEventHandler(scanDirectory_DirectoryEvent);

			// Add a FileEvent to the class
			scanDirectory.FileEvent += new ScanDirectory.FileEventHandler(scanDirectory_FileEvent);

			scanDirectory.WalkDirectory("C:\\Program Files");
		}

		/// <summary>
		/// Scans the directories starting at the specified path.
		/// </summary>
		/// <param name="path">The path.</param>
		private void ScanTheDirectories(string path)
		{
			// Create a new ScanDictory object
			ScanDirectory scanDirectory = new ScanDirectory();

			// Add a DirectoryEvent to the class
			scanDirectory.DirectoryEvent += new ScanDirectory.DirectoryEventHandler(scanDirectory_DirectoryEvent);

			// Add a FileEvent to the class
			scanDirectory.FileEvent += new ScanDirectory.FileEventHandler(scanDirectory_FileEvent);

			// Specify the search pattern
			scanDirectory.SearchPattern = textSearch.Text;

			// Walk returns false when the scan is cancelled.
			if (!scanDirectory.WalkDirectory(path))
			{
				panelText.Text = @"You cancelled the scan!";
			}
		}

		/// <summary>
		/// Handles the Click event of the buttonCancel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			buttonCancel.Enabled = false;
		}

		/// <summary>
		/// Handles the DirectoryEvent event of the scanDirectory control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DirectoryEventArgs"/> instance containing the event data.</param>
		private void scanDirectory_DirectoryEvent(object sender, DirectoryEventArgs e)
		{
			switch (e.Action)
			{
				case ScanDirectoryAction.Enter:
					TreeNode newNode = new TreeNode(e.Info.Name);

					if (_currentNode == null)
					{
						directoryTree.Nodes.Add(newNode);
					}
					else
					{
						_currentNode.Nodes.Add(newNode);
					}
					_currentNode = newNode;
					break;

				case ScanDirectoryAction.Leave:
					if (_currentNode.Parent != null)
					{
						_currentNode = _currentNode.Parent;
					}
					break;
			}
			
			UpdatePanel(e.Info.FullName);

			e.Cancel = !buttonCancel.Enabled;
		}

		/// <summary>
		/// Handles the FileEvent event of the scanDirectory control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FileEventArgs"/> instance containing the event data.</param>
		private void scanDirectory_FileEvent(object sender, FileEventArgs e)
		{
			_currentNode.Nodes.Add(new TreeNode(e.Info.Name));

			UpdatePanel(e.Info.FullName);
			
			e.Cancel = !buttonCancel.Enabled;
		}

		/// <summary>
		/// Updates the panel with the specified text and calls the Application.DoEvents to make
		/// sure the form is updated.
		/// </summary>
		/// <param name="text">The text to be displayed.</param>
		private void UpdatePanel(string text)
		{
			panelText.Text = text;
			Application.DoEvents();
		}
	}
}