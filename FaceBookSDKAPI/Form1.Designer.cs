namespace FaceBookSDKAPI
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
            this.WebFaceBook = new System.Windows.Forms.WebBrowser();
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.listBox_FriendList = new System.Windows.Forms.ListBox();
            this.Btn_GetFriendList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebFaceBook
            // 
            this.WebFaceBook.Location = new System.Drawing.Point(0, 0);
            this.WebFaceBook.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebFaceBook.Name = "WebFaceBook";
            this.WebFaceBook.Size = new System.Drawing.Size(291, 262);
            this.WebFaceBook.TabIndex = 0;
            this.WebFaceBook.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebFaceBook_DocumentCompleted);
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.Location = new System.Drawing.Point(104, 268);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(75, 23);
            this.Btn_SignIn.TabIndex = 1;
            this.Btn_SignIn.Text = "Sign In";
            this.Btn_SignIn.UseVisualStyleBackColor = true;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // listBox_FriendList
            // 
            this.listBox_FriendList.FormattingEnabled = true;
            this.listBox_FriendList.Location = new System.Drawing.Point(297, 12);
            this.listBox_FriendList.Name = "listBox_FriendList";
            this.listBox_FriendList.Size = new System.Drawing.Size(182, 251);
            this.listBox_FriendList.TabIndex = 2;
            // 
            // Btn_GetFriendList
            // 
            this.Btn_GetFriendList.Location = new System.Drawing.Point(350, 269);
            this.Btn_GetFriendList.Name = "Btn_GetFriendList";
            this.Btn_GetFriendList.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetFriendList.TabIndex = 3;
            this.Btn_GetFriendList.Text = "Get Friends";
            this.Btn_GetFriendList.UseVisualStyleBackColor = true;
            this.Btn_GetFriendList.Click += new System.EventHandler(this.Btn_GetFriendList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 303);
            this.Controls.Add(this.Btn_GetFriendList);
            this.Controls.Add(this.listBox_FriendList);
            this.Controls.Add(this.Btn_SignIn);
            this.Controls.Add(this.WebFaceBook);
            this.Name = "Form1";
            this.Text = "Sign In";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebFaceBook;
        private System.Windows.Forms.Button Btn_SignIn;
        private System.Windows.Forms.ListBox listBox_FriendList;
        private System.Windows.Forms.Button Btn_GetFriendList;
    }
}

