namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBook = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBookCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLabel = new System.Windows.Forms.Label();
            this.bookBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.loadBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStrip,
            this.editToolStrip,
            this.helpToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStrip
            // 
            this.fIleToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.loadBooksToolStripMenuItem,
            this.saveBooksToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStrip.Name = "fIleToolStrip";
            this.fIleToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStrip.Text = "&File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStrip
            // 
            this.editToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.removeBook,
            this.clearBookListToolStripMenuItem,
            this.displayBookCountToolStripMenuItem});
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(39, 20);
            this.editToolStrip.Text = "&Edit";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // removeBook
            // 
            this.removeBook.Name = "removeBook";
            this.removeBook.Size = new System.Drawing.Size(184, 22);
            this.removeBook.Text = "Remove Book";
            this.removeBook.Click += new System.EventHandler(this.removeBook_Click);
            // 
            // clearBookListToolStripMenuItem
            // 
            this.clearBookListToolStripMenuItem.Name = "clearBookListToolStripMenuItem";
            this.clearBookListToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clearBookListToolStripMenuItem.Text = "Clear Book List";
            this.clearBookListToolStripMenuItem.Click += new System.EventHandler(this.clearBookListToolStripMenuItem_Click);
            // 
            // displayBookCountToolStripMenuItem
            // 
            this.displayBookCountToolStripMenuItem.Name = "displayBookCountToolStripMenuItem";
            this.displayBookCountToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.displayBookCountToolStripMenuItem.Text = "Display Book Count  ";
            this.displayBookCountToolStripMenuItem.Click += new System.EventHandler(this.displayBookCountToolStripMenuItem_Click);
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolStrip.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(12, 61);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(64, 13);
            this.bookLabel.TabIndex = 3;
            this.bookLabel.Text = "Book List:";
            // 
            // bookBox
            // 
            this.bookBox.FormattingEnabled = true;
            this.bookBox.Items.AddRange(new object[] {
            "How to Program",
            "Introduction to Programming",
            "Problem Solving and Programming",
            "Object-Oriented Programming",
            "Program Design and Data Structures "});
            this.bookBox.Location = new System.Drawing.Point(17, 103);
            this.bookBox.Name = "bookBox";
            this.bookBox.Size = new System.Drawing.Size(225, 21);
            this.bookBox.TabIndex = 4;
            this.bookBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // loadBooksToolStripMenuItem
            // 
            this.loadBooksToolStripMenuItem.Name = "loadBooksToolStripMenuItem";
            this.loadBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadBooksToolStripMenuItem.Text = "Load Books";
            this.loadBooksToolStripMenuItem.Click += new System.EventHandler(this.loadBooksToolStripMenuItem_Click);
            // 
            // saveBooksToolStripMenuItem
            // 
            this.saveBooksToolStripMenuItem.Name = "saveBooksToolStripMenuItem";
            this.saveBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveBooksToolStripMenuItem.Text = "Save Books";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 197);
            this.Controls.Add(this.bookBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bookLabel);
            this.Name = "Form1";
            this.Text = "CS10a By Jared Adamson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStrip;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBook;
        private System.Windows.Forms.ToolStripMenuItem clearBookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBookCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ComboBox bookBox;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem loadBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBooksToolStripMenuItem;
    }
}

