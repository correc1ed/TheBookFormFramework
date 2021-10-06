
using System.Windows.Forms;

namespace TheBookFormFramework
{
    partial class TheBooksFramework : Form
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textTheBookName = new System.Windows.Forms.TextBox();
            this.TheBookNameLabel = new System.Windows.Forms.Label();
            this.TheBookAuthorLabel = new System.Windows.Forms.Label();
            this.textTheBookAuthor = new System.Windows.Forms.TextBox();
            this.TheBookNumberOfPagesLabel = new System.Windows.Forms.Label();
            this.textTheBookNumberOfPages = new System.Windows.Forms.TextBox();
            this.TheBookValuationLabel = new System.Windows.Forms.Label();
            this.comboTheBookValuation = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.outPage = new System.Windows.Forms.TabPage();
            this.addPage = new System.Windows.Forms.TabPage();
            this.buttonRandomFill = new System.Windows.Forms.Button();
            this.buttonClearForAdd = new System.Windows.Forms.Button();
            this.updatePage = new System.Windows.Forms.TabPage();
            this.buttonClearForUpdate = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.comboOUT = new System.Windows.Forms.ComboBox();
            this.textupdateOUT = new System.Windows.Forms.TextBox();
            this.comboIN = new System.Windows.Forms.ComboBox();
            this.textupdateIN = new System.Windows.Forms.TextBox();
            this.deletePage = new System.Windows.Forms.TabPage();
            this.buttonClearForDelete = new System.Windows.Forms.Button();
            this.comboForDelete = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textforDelete = new System.Windows.Forms.TextBox();
            this.labelTableOut = new System.Windows.Forms.Label();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.outPage.SuspendLayout();
            this.addPage.SuspendLayout();
            this.updatePage.SuspendLayout();
            this.deletePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(129, 136);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 32);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textTheBookName
            // 
            this.textTheBookName.Location = new System.Drawing.Point(129, 28);
            this.textTheBookName.Multiline = true;
            this.textTheBookName.Name = "textTheBookName";
            this.textTheBookName.Size = new System.Drawing.Size(137, 21);
            this.textTheBookName.TabIndex = 1;
            // 
            // TheBookNameLabel
            // 
            this.TheBookNameLabel.AutoSize = true;
            this.TheBookNameLabel.Location = new System.Drawing.Point(85, 36);
            this.TheBookNameLabel.Name = "TheBookNameLabel";
            this.TheBookNameLabel.Size = new System.Drawing.Size(35, 13);
            this.TheBookNameLabel.TabIndex = 2;
            this.TheBookNameLabel.Text = "Name";
            // 
            // TheBookAuthorLabel
            // 
            this.TheBookAuthorLabel.AutoSize = true;
            this.TheBookAuthorLabel.Location = new System.Drawing.Point(85, 63);
            this.TheBookAuthorLabel.Name = "TheBookAuthorLabel";
            this.TheBookAuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.TheBookAuthorLabel.TabIndex = 4;
            this.TheBookAuthorLabel.Text = "Author";
            // 
            // textTheBookAuthor
            // 
            this.textTheBookAuthor.Location = new System.Drawing.Point(129, 55);
            this.textTheBookAuthor.Multiline = true;
            this.textTheBookAuthor.Name = "textTheBookAuthor";
            this.textTheBookAuthor.Size = new System.Drawing.Size(137, 21);
            this.textTheBookAuthor.TabIndex = 3;
            // 
            // TheBookNumberOfPagesLabel
            // 
            this.TheBookNumberOfPagesLabel.AutoSize = true;
            this.TheBookNumberOfPagesLabel.Location = new System.Drawing.Point(32, 90);
            this.TheBookNumberOfPagesLabel.Name = "TheBookNumberOfPagesLabel";
            this.TheBookNumberOfPagesLabel.Size = new System.Drawing.Size(91, 13);
            this.TheBookNumberOfPagesLabel.TabIndex = 6;
            this.TheBookNumberOfPagesLabel.Text = "Number Of Pages";
            // 
            // textTheBookNumberOfPages
            // 
            this.textTheBookNumberOfPages.Location = new System.Drawing.Point(129, 82);
            this.textTheBookNumberOfPages.Multiline = true;
            this.textTheBookNumberOfPages.Name = "textTheBookNumberOfPages";
            this.textTheBookNumberOfPages.Size = new System.Drawing.Size(137, 21);
            this.textTheBookNumberOfPages.TabIndex = 5;
            // 
            // TheBookValuationLabel
            // 
            this.TheBookValuationLabel.AutoSize = true;
            this.TheBookValuationLabel.Location = new System.Drawing.Point(69, 117);
            this.TheBookValuationLabel.Name = "TheBookValuationLabel";
            this.TheBookValuationLabel.Size = new System.Drawing.Size(51, 13);
            this.TheBookValuationLabel.TabIndex = 8;
            this.TheBookValuationLabel.Text = "Valuation";
            // 
            // comboTheBookValuation
            // 
            this.comboTheBookValuation.FormattingEnabled = true;
            this.comboTheBookValuation.Items.AddRange(new object[] {
            "Bad",
            "Secondary",
            "Good",
            "Very Good"});
            this.comboTheBookValuation.Location = new System.Drawing.Point(129, 109);
            this.comboTheBookValuation.Name = "comboTheBookValuation";
            this.comboTheBookValuation.Size = new System.Drawing.Size(137, 21);
            this.comboTheBookValuation.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.outPage);
            this.tabControl1.Controls.Add(this.addPage);
            this.tabControl1.Controls.Add(this.updatePage);
            this.tabControl1.Controls.Add(this.deletePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 507);
            this.tabControl1.TabIndex = 11;
            // 
            // outPage
            // 
            this.outPage.Controls.Add(this.listViewTable);
            this.outPage.Controls.Add(this.labelTableOut);
            this.outPage.Location = new System.Drawing.Point(4, 22);
            this.outPage.Margin = new System.Windows.Forms.Padding(2);
            this.outPage.Name = "outPage";
            this.outPage.Padding = new System.Windows.Forms.Padding(2);
            this.outPage.Size = new System.Drawing.Size(885, 481);
            this.outPage.TabIndex = 0;
            this.outPage.Text = "Таблица данных";
            this.outPage.UseVisualStyleBackColor = true;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.buttonRandomFill);
            this.addPage.Controls.Add(this.buttonClearForAdd);
            this.addPage.Controls.Add(this.buttonAdd);
            this.addPage.Controls.Add(this.textTheBookName);
            this.addPage.Controls.Add(this.TheBookNumberOfPagesLabel);
            this.addPage.Controls.Add(this.textTheBookAuthor);
            this.addPage.Controls.Add(this.comboTheBookValuation);
            this.addPage.Controls.Add(this.TheBookAuthorLabel);
            this.addPage.Controls.Add(this.TheBookNameLabel);
            this.addPage.Controls.Add(this.TheBookValuationLabel);
            this.addPage.Controls.Add(this.textTheBookNumberOfPages);
            this.addPage.Location = new System.Drawing.Point(4, 22);
            this.addPage.Margin = new System.Windows.Forms.Padding(2);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(2);
            this.addPage.Size = new System.Drawing.Size(885, 481);
            this.addPage.TabIndex = 1;
            this.addPage.Text = "Ввод данных";
            this.addPage.UseVisualStyleBackColor = true;
            // 
            // buttonRandomFill
            // 
            this.buttonRandomFill.Location = new System.Drawing.Point(272, 99);
            this.buttonRandomFill.Name = "buttonRandomFill";
            this.buttonRandomFill.Size = new System.Drawing.Size(137, 32);
            this.buttonRandomFill.TabIndex = 11;
            this.buttonRandomFill.Text = "Fill Randomly";
            this.buttonRandomFill.UseVisualStyleBackColor = true;
            this.buttonRandomFill.Click += new System.EventHandler(this.buttonRandomFill_Click);
            // 
            // buttonClearForAdd
            // 
            this.buttonClearForAdd.Location = new System.Drawing.Point(272, 136);
            this.buttonClearForAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearForAdd.Name = "buttonClearForAdd";
            this.buttonClearForAdd.Size = new System.Drawing.Size(137, 32);
            this.buttonClearForAdd.TabIndex = 10;
            this.buttonClearForAdd.Text = "Clear";
            this.buttonClearForAdd.UseVisualStyleBackColor = true;
            this.buttonClearForAdd.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // updatePage
            // 
            this.updatePage.Controls.Add(this.buttonClearForUpdate);
            this.updatePage.Controls.Add(this.buttonUPDATE);
            this.updatePage.Controls.Add(this.comboOUT);
            this.updatePage.Controls.Add(this.textupdateOUT);
            this.updatePage.Controls.Add(this.comboIN);
            this.updatePage.Controls.Add(this.textupdateIN);
            this.updatePage.Location = new System.Drawing.Point(4, 22);
            this.updatePage.Margin = new System.Windows.Forms.Padding(2);
            this.updatePage.Name = "updatePage";
            this.updatePage.Size = new System.Drawing.Size(885, 481);
            this.updatePage.TabIndex = 2;
            this.updatePage.Text = "Редактирование данных";
            this.updatePage.UseVisualStyleBackColor = true;
            // 
            // buttonClearForUpdate
            // 
            this.buttonClearForUpdate.Location = new System.Drawing.Point(346, 190);
            this.buttonClearForUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearForUpdate.Name = "buttonClearForUpdate";
            this.buttonClearForUpdate.Size = new System.Drawing.Size(172, 38);
            this.buttonClearForUpdate.TabIndex = 11;
            this.buttonClearForUpdate.Text = "Clear";
            this.buttonClearForUpdate.UseVisualStyleBackColor = true;
            this.buttonClearForUpdate.Click += new System.EventHandler(this.buttonClearForUpdate_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(346, 138);
            this.buttonUPDATE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(172, 47);
            this.buttonUPDATE.TabIndex = 8;
            this.buttonUPDATE.Text = "Update";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // comboOUT
            // 
            this.comboOUT.FormattingEnabled = true;
            this.comboOUT.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Author",
            "PageOfNumber",
            "Valuation"});
            this.comboOUT.Location = new System.Drawing.Point(571, 228);
            this.comboOUT.Margin = new System.Windows.Forms.Padding(2);
            this.comboOUT.Name = "comboOUT";
            this.comboOUT.Size = new System.Drawing.Size(137, 21);
            this.comboOUT.TabIndex = 7;
            // 
            // textupdateOUT
            // 
            this.textupdateOUT.Location = new System.Drawing.Point(711, 228);
            this.textupdateOUT.Margin = new System.Windows.Forms.Padding(2);
            this.textupdateOUT.Multiline = true;
            this.textupdateOUT.Name = "textupdateOUT";
            this.textupdateOUT.Size = new System.Drawing.Size(171, 20);
            this.textupdateOUT.TabIndex = 6;
            // 
            // comboIN
            // 
            this.comboIN.FormattingEnabled = true;
            this.comboIN.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Author",
            "PageOfNumber",
            "Valuation"});
            this.comboIN.Location = new System.Drawing.Point(34, 30);
            this.comboIN.Margin = new System.Windows.Forms.Padding(2);
            this.comboIN.Name = "comboIN";
            this.comboIN.Size = new System.Drawing.Size(137, 21);
            this.comboIN.TabIndex = 5;
            // 
            // textupdateIN
            // 
            this.textupdateIN.Location = new System.Drawing.Point(174, 30);
            this.textupdateIN.Margin = new System.Windows.Forms.Padding(2);
            this.textupdateIN.Multiline = true;
            this.textupdateIN.Name = "textupdateIN";
            this.textupdateIN.Size = new System.Drawing.Size(171, 20);
            this.textupdateIN.TabIndex = 4;
            // 
            // deletePage
            // 
            this.deletePage.Controls.Add(this.buttonClearForDelete);
            this.deletePage.Controls.Add(this.comboForDelete);
            this.deletePage.Controls.Add(this.buttonDelete);
            this.deletePage.Controls.Add(this.textforDelete);
            this.deletePage.Location = new System.Drawing.Point(4, 22);
            this.deletePage.Margin = new System.Windows.Forms.Padding(2);
            this.deletePage.Name = "deletePage";
            this.deletePage.Size = new System.Drawing.Size(885, 481);
            this.deletePage.TabIndex = 3;
            this.deletePage.Text = "Удаление данных";
            this.deletePage.UseVisualStyleBackColor = true;
            // 
            // buttonClearForDelete
            // 
            this.buttonClearForDelete.Location = new System.Drawing.Point(168, 53);
            this.buttonClearForDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearForDelete.Name = "buttonClearForDelete";
            this.buttonClearForDelete.Size = new System.Drawing.Size(83, 27);
            this.buttonClearForDelete.TabIndex = 12;
            this.buttonClearForDelete.Text = "Clear";
            this.buttonClearForDelete.UseVisualStyleBackColor = true;
            this.buttonClearForDelete.Click += new System.EventHandler(this.buttonClearForDelete_Click);
            // 
            // comboForDelete
            // 
            this.comboForDelete.FormattingEnabled = true;
            this.comboForDelete.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Author",
            "PageOfNumber",
            "Valuation"});
            this.comboForDelete.Location = new System.Drawing.Point(28, 28);
            this.comboForDelete.Margin = new System.Windows.Forms.Padding(2);
            this.comboForDelete.Name = "comboForDelete";
            this.comboForDelete.Size = new System.Drawing.Size(137, 21);
            this.comboForDelete.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(256, 53);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 27);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textforDelete
            // 
            this.textforDelete.Location = new System.Drawing.Point(169, 28);
            this.textforDelete.Margin = new System.Windows.Forms.Padding(2);
            this.textforDelete.Multiline = true;
            this.textforDelete.Name = "textforDelete";
            this.textforDelete.Size = new System.Drawing.Size(171, 20);
            this.textforDelete.TabIndex = 0;
            // 
            // labelTableOut
            // 
            this.labelTableOut.AutoSize = true;
            this.labelTableOut.Location = new System.Drawing.Point(32, 26);
            this.labelTableOut.Name = "labelTableOut";
            this.labelTableOut.Size = new System.Drawing.Size(35, 13);
            this.labelTableOut.TabIndex = 12;
            this.labelTableOut.Text = "label1";
            // 
            // listViewTable
            // 
            this.listViewTable.HideSelection = false;
            this.listViewTable.Location = new System.Drawing.Point(146, 5);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(731, 461);
            this.listViewTable.TabIndex = 13;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TheBooksFramework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "TheBooksFramework";
            this.Text = "TheBooksFramework";
            this.Load += new System.EventHandler(this.TheBooksFramework_Load);
            this.tabControl1.ResumeLayout(false);
            this.outPage.ResumeLayout(false);
            this.outPage.PerformLayout();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.updatePage.ResumeLayout(false);
            this.updatePage.PerformLayout();
            this.deletePage.ResumeLayout(false);
            this.deletePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textTheBookName;
        private System.Windows.Forms.Label TheBookNameLabel;
        private System.Windows.Forms.Label TheBookAuthorLabel;
        private System.Windows.Forms.TextBox textTheBookAuthor;
        private System.Windows.Forms.Label TheBookNumberOfPagesLabel;
        private System.Windows.Forms.TextBox textTheBookNumberOfPages;
        private System.Windows.Forms.Label TheBookValuationLabel;
        private System.Windows.Forms.ComboBox comboTheBookValuation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage outPage;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TabPage updatePage;
        private System.Windows.Forms.TabPage deletePage;
        private System.Windows.Forms.Button buttonClearForAdd;
        private System.Windows.Forms.TextBox textforDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboForDelete;
        private System.Windows.Forms.ComboBox comboOUT;
        private System.Windows.Forms.TextBox textupdateOUT;
        private System.Windows.Forms.ComboBox comboIN;
        private System.Windows.Forms.TextBox textupdateIN;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Button buttonRandomFill;
        private System.Windows.Forms.Button buttonClearForUpdate;
        private System.Windows.Forms.Button buttonClearForDelete;
        private Label labelTableOut;
        private ListView listViewTable;
    }
}

