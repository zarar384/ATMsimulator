
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ATMsimulator
{
    partial class FormAtm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtm));
            this.panelLaunch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPin = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.panelStartMenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonBackStartMenu = new System.Windows.Forms.Button();
            this.panelDeposit = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMyBalance = new System.Windows.Forms.Button();
            this.buttonBackDeposit = new System.Windows.Forms.Button();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textMoney = new System.Windows.Forms.Label();
            this.buttonBackBalance = new System.Windows.Forms.Button();
            this.panelDepositMyBalance = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            this.buttonConfirmDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDepositMyBalance = new System.Windows.Forms.TextBox();
            this.buttonDepositMyBalance = new System.Windows.Forms.Button();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMyPin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownMoney = new System.Windows.Forms.NumericUpDown();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBackRegistration = new System.Windows.Forms.Button();
            this.panelLaunch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelStartMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelDeposit.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelDepositMyBalance.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelRegistration.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLaunch
            // 
            this.panelLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelLaunch.Controls.Add(this.panel1);
            this.panelLaunch.Controls.Add(this.button1);
            this.panelLaunch.Location = new System.Drawing.Point(7, 12);
            this.panelLaunch.Name = "panelLaunch";
            this.panelLaunch.Size = new System.Drawing.Size(573, 413);
            this.panelLaunch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.listViewPerson);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.linkRegistration);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 80);
            this.panel1.TabIndex = 7;
            // 
            // listViewPerson
            // 
            this.listViewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listViewPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.listViewPerson.HideSelection = false;
            this.listViewPerson.Location = new System.Drawing.Point(326, 26);
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(100, 34);
            this.listViewPerson.TabIndex = 6;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.Click += new System.EventHandler(this.listViewPerson_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(15, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ještě nemáte účet?";
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkRegistration.Location = new System.Drawing.Point(189, 32);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(113, 20);
            this.linkRegistration.TabIndex = 3;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Registrujte se";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(171, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "VLOŽIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLaunch_MouseClick);
            // 
            // panelPin
            // 
            this.panelPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelPin.Controls.Add(this.panel4);
            this.panelPin.Location = new System.Drawing.Point(6, 11);
            this.panelPin.Name = "panelPin";
            this.panelPin.Size = new System.Drawing.Size(573, 413);
            this.panelPin.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBoxPin);
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 80);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(255, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "PIN";
            // 
            // textBoxPin
            // 
            this.textBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.textBoxPin.Location = new System.Drawing.Point(240, 49);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(100, 27);
            this.textBoxPin.TabIndex = 0;
            this.textBoxPin.TextChanged += new System.EventHandler(this.textBoxPin_TextChanged);
            // 
            // panelStartMenu
            // 
            this.panelStartMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelStartMenu.Controls.Add(this.panel5);
            this.panelStartMenu.Controls.Add(this.buttonDeposit);
            this.panelStartMenu.Controls.Add(this.buttonBalance);
            this.panelStartMenu.Controls.Add(this.buttonBackStartMenu);
            this.panelStartMenu.Location = new System.Drawing.Point(7, 12);
            this.panelStartMenu.Name = "panelStartMenu";
            this.panelStartMenu.Size = new System.Drawing.Size(573, 413);
            this.panelStartMenu.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 80);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(91, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dobrý den, jaké máte přání.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.buttonDeposit.Location = new System.Drawing.Point(408, 317);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(126, 64);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "VKLAD HOTOVOSTI";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDeposit_MouseDown);
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.buttonBalance.Location = new System.Drawing.Point(408, 214);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(126, 64);
            this.buttonBalance.TabIndex = 1;
            this.buttonBalance.Text = "ZŮSTATEK";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBalance_MouseDown);
            // 
            // buttonBackStartMenu
            // 
            this.buttonBackStartMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.buttonBackStartMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackStartMenu.Location = new System.Drawing.Point(38, 316);
            this.buttonBackStartMenu.Name = "buttonBackStartMenu";
            this.buttonBackStartMenu.Size = new System.Drawing.Size(126, 64);
            this.buttonBackStartMenu.TabIndex = 0;
            this.buttonBackStartMenu.Text = "ZPĚT";
            this.buttonBackStartMenu.UseVisualStyleBackColor = false;
            this.buttonBackStartMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBackStartMenu_MouseClick);
            // 
            // panelDeposit
            // 
            this.panelDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelDeposit.Controls.Add(this.panel6);
            this.panelDeposit.Controls.Add(this.buttonMyBalance);
            this.panelDeposit.Controls.Add(this.buttonBackDeposit);
            this.panelDeposit.Location = new System.Drawing.Point(7, 11);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(573, 413);
            this.panelDeposit.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(573, 80);
            this.panel6.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(73, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(426, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Zvolte účet, na který chcete vložit peníze, prosím.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(178, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vložit hotovost";
            // 
            // buttonMyBalance
            // 
            this.buttonMyBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.buttonMyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.buttonMyBalance.Location = new System.Drawing.Point(408, 317);
            this.buttonMyBalance.Name = "buttonMyBalance";
            this.buttonMyBalance.Size = new System.Drawing.Size(126, 64);
            this.buttonMyBalance.TabIndex = 1;
            this.buttonMyBalance.Text = "ÚČET KE KARTĚ";
            this.buttonMyBalance.UseVisualStyleBackColor = false;
            this.buttonMyBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMyBalance_MouseDown);
            // 
            // buttonBackDeposit
            // 
            this.buttonBackDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.buttonBackDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackDeposit.Location = new System.Drawing.Point(38, 316);
            this.buttonBackDeposit.Name = "buttonBackDeposit";
            this.buttonBackDeposit.Size = new System.Drawing.Size(126, 64);
            this.buttonBackDeposit.TabIndex = 0;
            this.buttonBackDeposit.Text = "ZPĚT";
            this.buttonBackDeposit.UseVisualStyleBackColor = false;
            this.buttonBackDeposit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonBackDeposit_MouseClick);
            // 
            // panelBalance
            // 
            this.panelBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelBalance.Controls.Add(this.panel8);
            this.panelBalance.Controls.Add(this.buttonBackBalance);
            this.panelBalance.Location = new System.Drawing.Point(5, 10);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(573, 413);
            this.panelBalance.TabIndex = 3;
            this.panelBalance.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBalance_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel8.Controls.Add(this.textMoney);
            this.panel8.Location = new System.Drawing.Point(0, 147);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(573, 80);
            this.panel8.TabIndex = 9;
            // 
            // textMoney
            // 
            this.textMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMoney.AutoSize = true;
            this.textMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textMoney.Location = new System.Drawing.Point(74, 28);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(302, 32);
            this.textMoney.TabIndex = 1;
            this.textMoney.Text = "Na kartě máte {0} czk";
            this.textMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBackBalance
            // 
            this.buttonBackBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.buttonBackBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackBalance.Location = new System.Drawing.Point(38, 316);
            this.buttonBackBalance.Name = "buttonBackBalance";
            this.buttonBackBalance.Size = new System.Drawing.Size(126, 64);
            this.buttonBackBalance.TabIndex = 0;
            this.buttonBackBalance.Text = "ZPĚT";
            this.buttonBackBalance.UseVisualStyleBackColor = false;
            this.buttonBackBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBackBalance_MouseDown);
            // 
            // panelDepositMyBalance
            // 
            this.panelDepositMyBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelDepositMyBalance.Controls.Add(this.panel7);
            this.panelDepositMyBalance.Controls.Add(this.buttonConfirmDeposit);
            this.panelDepositMyBalance.Controls.Add(this.label3);
            this.panelDepositMyBalance.Controls.Add(this.textBoxDepositMyBalance);
            this.panelDepositMyBalance.Controls.Add(this.buttonDepositMyBalance);
            this.panelDepositMyBalance.Location = new System.Drawing.Point(6, 11);
            this.panelDepositMyBalance.Name = "panelDepositMyBalance";
            this.panelDepositMyBalance.Size = new System.Drawing.Size(573, 413);
            this.panelDepositMyBalance.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel7.Controls.Add(this.labelDepositAmount);
            this.panel7.Location = new System.Drawing.Point(0, 124);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(573, 80);
            this.panel7.TabIndex = 9;
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.AutoSize = true;
            this.labelDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelDepositAmount.Location = new System.Drawing.Point(166, 27);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(163, 32);
            this.labelDepositAmount.TabIndex = 1;
            this.labelDepositAmount.Text = "Částka: {0}";
            this.labelDepositAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConfirmDeposit
            // 
            this.buttonConfirmDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.buttonConfirmDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirmDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.buttonConfirmDeposit.Location = new System.Drawing.Point(408, 317);
            this.buttonConfirmDeposit.Name = "buttonConfirmDeposit";
            this.buttonConfirmDeposit.Size = new System.Drawing.Size(126, 64);
            this.buttonConfirmDeposit.TabIndex = 4;
            this.buttonConfirmDeposit.Text = "POTVRDIT VKLAD";
            this.buttonConfirmDeposit.UseVisualStyleBackColor = false;
            this.buttonConfirmDeposit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonConfirmDeposit_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zadejte částku";
            // 
            // textBoxDepositMyBalance
            // 
            this.textBoxDepositMyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDepositMyBalance.Location = new System.Drawing.Point(238, 270);
            this.textBoxDepositMyBalance.Name = "textBoxDepositMyBalance";
            this.textBoxDepositMyBalance.Size = new System.Drawing.Size(100, 27);
            this.textBoxDepositMyBalance.TabIndex = 2;
            // 
            // buttonDepositMyBalance
            // 
            this.buttonDepositMyBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.buttonDepositMyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDepositMyBalance.Location = new System.Drawing.Point(38, 316);
            this.buttonDepositMyBalance.Name = "buttonDepositMyBalance";
            this.buttonDepositMyBalance.Size = new System.Drawing.Size(126, 64);
            this.buttonDepositMyBalance.TabIndex = 0;
            this.buttonDepositMyBalance.Text = "ZPĚT";
            this.buttonDepositMyBalance.UseVisualStyleBackColor = false;
            this.buttonDepositMyBalance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDepositMyBalance_MouseDown);
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelRegistration.Controls.Add(this.panel2);
            this.panelRegistration.Controls.Add(this.panel3);
            this.panelRegistration.Controls.Add(this.button3);
            this.panelRegistration.Controls.Add(this.buttonBackRegistration);
            this.panelRegistration.Location = new System.Drawing.Point(7, 12);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(573, 413);
            this.panelRegistration.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 80);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(178, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRACE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxMyPin);
            this.panel3.Controls.Add(this.textBoxName);
            this.panel3.Controls.Add(this.numericUpDownMoney);
            this.panel3.Controls.Add(this.textBoxSecondName);
            this.panel3.Controls.Add(this.textBoxMonth);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxYear);
            this.panel3.Controls.Add(this.textBoxDate);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(162, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 207);
            this.panel3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label12.Location = new System.Drawing.Point(3, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jméno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(3, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Penize";
            // 
            // textBoxMyPin
            // 
            this.textBoxMyPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMyPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxMyPin.Location = new System.Drawing.Point(132, 125);
            this.textBoxMyPin.Name = "textBoxMyPin";
            this.textBoxMyPin.ReadOnly = true;
            this.textBoxMyPin.Size = new System.Drawing.Size(100, 27);
            this.textBoxMyPin.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxName.Location = new System.Drawing.Point(132, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 27);
            this.textBoxName.TabIndex = 2;
            // 
            // numericUpDownMoney
            // 
            this.numericUpDownMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.numericUpDownMoney.Location = new System.Drawing.Point(132, 165);
            this.numericUpDownMoney.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numericUpDownMoney.Name = "numericUpDownMoney";
            this.numericUpDownMoney.Size = new System.Drawing.Size(100, 27);
            this.numericUpDownMoney.TabIndex = 5;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxSecondName.Location = new System.Drawing.Point(132, 49);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 27);
            this.textBoxSecondName.TabIndex = 5;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxMonth.Location = new System.Drawing.Point(164, 87);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(28, 27);
            this.textBoxMonth.TabIndex = 13;
            this.textBoxMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMonth.TextChanged += new System.EventHandler(this.textBoxMonth_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Příjmení";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxYear.Location = new System.Drawing.Point(197, 87);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(35, 27);
            this.textBoxYear.TabIndex = 12;
            this.textBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.textBoxDate.Location = new System.Drawing.Point(132, 87);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(28, 27);
            this.textBoxDate.TabIndex = 7;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(3, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data narození";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(242)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(113)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(408, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "ZALOŽIT ÚČET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBackRegistration
            // 
            this.buttonBackRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.buttonBackRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackRegistration.Location = new System.Drawing.Point(38, 316);
            this.buttonBackRegistration.Name = "buttonBackRegistration";
            this.buttonBackRegistration.Size = new System.Drawing.Size(126, 64);
            this.buttonBackRegistration.TabIndex = 0;
            this.buttonBackRegistration.Text = "ZPĚT";
            this.buttonBackRegistration.UseVisualStyleBackColor = false;
            this.buttonBackRegistration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBackRegistration_MouseDown);
            // 
            // FormAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(144)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(587, 433);
            this.Controls.Add(this.panelRegistration);
            this.Controls.Add(this.panelDeposit);
            this.Controls.Add(this.panelDepositMyBalance);
            this.Controls.Add(this.panelStartMenu);
            this.Controls.Add(this.panelLaunch);
            this.Controls.Add(this.panelBalance);
            this.Controls.Add(this.panelPin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtm";
            this.Text = "ATM Simulator";
            this.Load += new System.EventHandler(this.FormAtm_Load);
            this.panelLaunch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPin.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelStartMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelDeposit.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelBalance.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelDepositMyBalance.ResumeLayout(false);
            this.panelDepositMyBalance.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelRegistration.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaunch;
        private System.Windows.Forms.Panel panelPin;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Button buttonBackStartMenu;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Panel panelStartMenu;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Label textMoney;
        private System.Windows.Forms.Button buttonBackBalance;
        private System.Windows.Forms.Panel panelDeposit;
        private System.Windows.Forms.Button buttonMyBalance;
        private System.Windows.Forms.Button buttonBackDeposit;
        private System.Windows.Forms.Panel panelDepositMyBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDepositMyBalance;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.Button buttonDepositMyBalance;
        private System.Windows.Forms.Button buttonConfirmDeposit;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonBackRegistration;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMyPin;
    }
}

