
namespace Server
{
    partial class StartForm
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
            this.btnEstablishConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldIP = new System.Windows.Forms.TextBox();
            this.fieldPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatusServer = new System.Windows.Forms.Label();
            this.lblServerMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            tbClientNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEstablishConnection
            // 
            this.btnEstablishConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEstablishConnection.Location = new System.Drawing.Point(28, 151);
            this.btnEstablishConnection.Name = "btnEstablishConnection";
            this.btnEstablishConnection.Size = new System.Drawing.Size(458, 52);
            this.btnEstablishConnection.TabIndex = 0;
            this.btnEstablishConnection.Text = "Launch server";
            this.btnEstablishConnection.UseVisualStyleBackColor = true;
            this.btnEstablishConnection.Click += new System.EventHandler(this.btnEstablishConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port number:";
            // 
            // fieldIP
            // 
            this.fieldIP.Location = new System.Drawing.Point(207, 25);
            this.fieldIP.Name = "fieldIP";
            this.fieldIP.Size = new System.Drawing.Size(154, 22);
            this.fieldIP.TabIndex = 3;
            // 
            // fieldPort
            // 
            this.fieldPort.Location = new System.Drawing.Point(207, 64);
            this.fieldPort.Name = "fieldPort";
            this.fieldPort.Size = new System.Drawing.Size(154, 22);
            this.fieldPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connection status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message from server:";
            // 
            // lblStatusServer
            // 
            this.lblStatusServer.AutoSize = true;
            this.lblStatusServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusServer.Location = new System.Drawing.Point(219, 215);
            this.lblStatusServer.Name = "lblStatusServer";
            this.lblStatusServer.Size = new System.Drawing.Size(114, 20);
            this.lblStatusServer.TabIndex = 7;
            this.lblStatusServer.Text = "not connected";
            // 
            // lblServerMessage
            // 
            this.lblServerMessage.AutoSize = true;
            this.lblServerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServerMessage.Location = new System.Drawing.Point(223, 249);
            this.lblServerMessage.Name = "lblServerMessage";
            this.lblServerMessage.Size = new System.Drawing.Size(0, 20);
            this.lblServerMessage.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of users:";
            // 
            // tbClientNum
            // 
            tbClientNum.Location = new System.Drawing.Point(206, 105);
            tbClientNum.Name = "tbClientNum";
            tbClientNum.Size = new System.Drawing.Size(154, 22);
            tbClientNum.TabIndex = 10;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 313);
            this.Controls.Add(tbClientNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblServerMessage);
            this.Controls.Add(this.lblStatusServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldPort);
            this.Controls.Add(this.fieldIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstablishConnection);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstablishConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldIP;
        private System.Windows.Forms.TextBox fieldPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblServerMessage;
        private System.Windows.Forms.Label lblStatusServer;
        private System.Windows.Forms.Label label5;
        public static System.Windows.Forms.TextBox tbClientNum;
    }
}