
namespace laba1_oop
{
    partial class frmStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldIP = new System.Windows.Forms.TextBox();
            this.fieldPort = new System.Windows.Forms.TextBox();
            this.EstablishConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            lblStatusClient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.fieldName = new System.Windows.Forms.TextBox();
            lblServerMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server address IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port number:";
            // 
            // fieldIP
            // 
            this.fieldIP.Location = new System.Drawing.Point(221, 81);
            this.fieldIP.Name = "fieldIP";
            this.fieldIP.Size = new System.Drawing.Size(161, 22);
            this.fieldIP.TabIndex = 2;
            // 
            // fieldPort
            // 
            this.fieldPort.Location = new System.Drawing.Point(221, 133);
            this.fieldPort.Name = "fieldPort";
            this.fieldPort.Size = new System.Drawing.Size(161, 22);
            this.fieldPort.TabIndex = 3;
            // 
            // EstablishConnection
            // 
            this.EstablishConnection.Location = new System.Drawing.Point(29, 182);
            this.EstablishConnection.Name = "EstablishConnection";
            this.EstablishConnection.Size = new System.Drawing.Size(420, 44);
            this.EstablishConnection.TabIndex = 4;
            this.EstablishConnection.Text = "Connect to the server";
            this.EstablishConnection.UseVisualStyleBackColor = true;
            this.EstablishConnection.Click += new System.EventHandler(this.EstablishConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connection status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Message from server:";
            // 
            // lblStatusClient
            // 
            lblStatusClient.AutoSize = true;
            lblStatusClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblStatusClient.Location = new System.Drawing.Point(217, 278);
            lblStatusClient.Name = "lblStatusClient";
            lblStatusClient.Size = new System.Drawing.Size(91, 16);
            lblStatusClient.TabIndex = 7;
            lblStatusClient.Text = "not connected";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(28, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name: ";
            // 
            // fieldName
            // 
            this.fieldName.Location = new System.Drawing.Point(221, 31);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(161, 22);
            this.fieldName.TabIndex = 10;
            // 
            // lblServerMessage
            // 
            lblServerMessage.AutoSize = true;
            lblServerMessage.Location = new System.Drawing.Point(217, 314);
            lblServerMessage.Name = "lblServerMessage";
            lblServerMessage.Size = new System.Drawing.Size(0, 16);
            lblServerMessage.TabIndex = 11;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 360);
            this.Controls.Add(lblServerMessage);
            this.Controls.Add(this.fieldName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(lblStatusClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EstablishConnection);
            this.Controls.Add(this.fieldPort);
            this.Controls.Add(this.fieldIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStart";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldIP;
        private System.Windows.Forms.TextBox fieldPort;
        private System.Windows.Forms.Button EstablishConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox fieldName;
        private static System.Windows.Forms.Label lblStatusClient;
        private static System.Windows.Forms.Label lblServerMessage;
    }
}