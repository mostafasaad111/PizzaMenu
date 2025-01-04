namespace WindowsFormsApp3
{
    partial class PizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.chGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chMushrooms = new System.Windows.Forms.CheckBox();
            this.chExtraChees = new System.Windows.Forms.CheckBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.gbEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOrderPiza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbEat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Size = new System.Drawing.Size(634, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR  PIZZA";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbSmall.Location = new System.Drawing.Point(25, 38);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(82, 27);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMedium.Location = new System.Drawing.Point(25, 71);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(103, 27);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbLarge.Location = new System.Drawing.Point(25, 113);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(70, 27);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Larg";
            this.rbLarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Lime;
            this.gbSize.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gbSize.Location = new System.Drawing.Point(12, 117);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(205, 161);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.Lime;
            this.gbCrust.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gbCrust.Location = new System.Drawing.Point(12, 320);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(205, 161);
            this.gbCrust.TabIndex = 5;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.ForeColor = System.Drawing.Color.White;
            this.rbThick.Location = new System.Drawing.Point(25, 92);
            this.rbThick.Margin = new System.Windows.Forms.Padding(2);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(148, 29);
            this.rbThick.TabIndex = 2;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.ForeColor = System.Drawing.Color.White;
            this.rbThin.Location = new System.Drawing.Point(25, 43);
            this.rbThin.Margin = new System.Windows.Forms.Padding(2);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(138, 29);
            this.rbThin.TabIndex = 1;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // chGreenPeppers
            // 
            this.chGreenPeppers.AutoSize = true;
            this.chGreenPeppers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chGreenPeppers.ForeColor = System.Drawing.Color.GhostWhite;
            this.chGreenPeppers.Location = new System.Drawing.Point(185, 114);
            this.chGreenPeppers.Name = "chGreenPeppers";
            this.chGreenPeppers.Size = new System.Drawing.Size(168, 27);
            this.chGreenPeppers.TabIndex = 6;
            this.chGreenPeppers.Tag = "5";
            this.chGreenPeppers.Text = "Green Peppers";
            this.chGreenPeppers.UseVisualStyleBackColor = true;
            this.chGreenPeppers.CheckedChanged += new System.EventHandler(this.chGreenPeppers_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOlives.ForeColor = System.Drawing.Color.GhostWhite;
            this.chOlives.Location = new System.Drawing.Point(185, 72);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(88, 27);
            this.chOlives.TabIndex = 7;
            this.chOlives.Tag = "5";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOnion.ForeColor = System.Drawing.Color.GhostWhite;
            this.chOnion.Location = new System.Drawing.Point(185, 30);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(86, 27);
            this.chOnion.TabIndex = 8;
            this.chOnion.Tag = "5";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatoes.ForeColor = System.Drawing.Color.GhostWhite;
            this.chTomatoes.Location = new System.Drawing.Point(17, 114);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(120, 27);
            this.chTomatoes.TabIndex = 9;
            this.chTomatoes.Tag = "5";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chMushrooms
            // 
            this.chMushrooms.AutoSize = true;
            this.chMushrooms.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMushrooms.ForeColor = System.Drawing.Color.GhostWhite;
            this.chMushrooms.Location = new System.Drawing.Point(17, 72);
            this.chMushrooms.Name = "chMushrooms";
            this.chMushrooms.Size = new System.Drawing.Size(139, 27);
            this.chMushrooms.TabIndex = 10;
            this.chMushrooms.Tag = "5";
            this.chMushrooms.Text = "Mushrooms";
            this.chMushrooms.UseVisualStyleBackColor = true;
            this.chMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // chExtraChees
            // 
            this.chExtraChees.AutoSize = true;
            this.chExtraChees.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chExtraChees.ForeColor = System.Drawing.Color.GhostWhite;
            this.chExtraChees.Location = new System.Drawing.Point(17, 30);
            this.chExtraChees.Name = "chExtraChees";
            this.chExtraChees.Size = new System.Drawing.Size(142, 27);
            this.chExtraChees.TabIndex = 11;
            this.chExtraChees.Tag = "5";
            this.chExtraChees.Text = "Extra Chees";
            this.chExtraChees.UseVisualStyleBackColor = true;
            this.chExtraChees.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.chMushrooms);
            this.gbTopping.Controls.Add(this.chOnion);
            this.gbTopping.Controls.Add(this.chExtraChees);
            this.gbTopping.Controls.Add(this.chOlives);
            this.gbTopping.Controls.Add(this.chGreenPeppers);
            this.gbTopping.Controls.Add(this.chTomatoes);
            this.gbTopping.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.ForeColor = System.Drawing.Color.Lime;
            this.gbTopping.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gbTopping.Location = new System.Drawing.Point(257, 117);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(374, 161);
            this.gbTopping.TabIndex = 6;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            this.gbTopping.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gbEat
            // 
            this.gbEat.BackColor = System.Drawing.Color.Transparent;
            this.gbEat.Controls.Add(this.rbEatOut);
            this.gbEat.Controls.Add(this.rbEatIn);
            this.gbEat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEat.ForeColor = System.Drawing.Color.Lime;
            this.gbEat.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gbEat.Location = new System.Drawing.Point(257, 320);
            this.gbEat.Name = "gbEat";
            this.gbEat.Size = new System.Drawing.Size(374, 161);
            this.gbEat.TabIndex = 6;
            this.gbEat.TabStop = false;
            this.gbEat.Text = "Where To Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatOut.ForeColor = System.Drawing.Color.White;
            this.rbEatOut.Location = new System.Drawing.Point(25, 92);
            this.rbEatOut.Margin = new System.Windows.Forms.Padding(2);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(109, 29);
            this.rbEatOut.TabIndex = 2;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.ForeColor = System.Drawing.Color.White;
            this.rbEatIn.Location = new System.Drawing.Point(25, 43);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(2);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(99, 29);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In ";
            this.rbEatIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.lbToppings);
            this.groupBox4.Controls.Add(this.lbEat);
            this.groupBox4.Controls.Add(this.lbCrustType);
            this.groupBox4.Controls.Add(this.lbSize);
            this.groupBox4.Controls.Add(this.lbPrice);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.groupBox4.Location = new System.Drawing.Point(661, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 484);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Summary";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.White;
            this.lbToppings.Location = new System.Drawing.Point(6, 116);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(56, 18);
            this.lbToppings.TabIndex = 14;
            this.lbToppings.Text = "Onion";
            // 
            // lbEat
            // 
            this.lbEat.AutoSize = true;
            this.lbEat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEat.ForeColor = System.Drawing.Color.White;
            this.lbEat.Location = new System.Drawing.Point(85, 282);
            this.lbEat.Name = "lbEat";
            this.lbEat.Size = new System.Drawing.Size(91, 25);
            this.lbEat.TabIndex = 12;
            this.lbEat.Text = "Eat Out";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.ForeColor = System.Drawing.Color.White;
            this.lbCrustType.Location = new System.Drawing.Point(85, 203);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(120, 25);
            this.lbCrustType.TabIndex = 11;
            this.lbCrustType.Text = "Thin Crust";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(85, 38);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(71, 25);
            this.lbSize.TabIndex = 10;
            this.lbSize.Text = "Small";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Lime;
            this.lbPrice.Location = new System.Drawing.Point(81, 363);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(148, 103);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "30$";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(6, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Where To Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(3, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tappings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size :";
            // 
            // btOrderPiza
            // 
            this.btOrderPiza.BackColor = System.Drawing.Color.Lime;
            this.btOrderPiza.ForeColor = System.Drawing.Color.White;
            this.btOrderPiza.Location = new System.Drawing.Point(116, 553);
            this.btOrderPiza.Name = "btOrderPiza";
            this.btOrderPiza.Size = new System.Drawing.Size(174, 48);
            this.btOrderPiza.TabIndex = 8;
            this.btOrderPiza.Text = "Order Pizaa";
            this.btOrderPiza.UseVisualStyleBackColor = false;
            this.btOrderPiza.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(367, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 664);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btOrderPiza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbEat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "PizzaOrder";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Piza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbEat.ResumeLayout(false);
            this.gbEat.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.CheckBox chGreenPeppers;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chMushrooms;
        private System.Windows.Forms.CheckBox chExtraChees;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.GroupBox gbEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOrderPiza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbSize;
    }
}

