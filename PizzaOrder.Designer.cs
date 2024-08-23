namespace PizzaProject
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
            this.lHeaderName = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdbtnLarge = new System.Windows.Forms.RadioButton();
            this.rdbtnMedium = new System.Windows.Forms.RadioButton();
            this.rdbtnSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rdbtnThickCrust = new System.Windows.Forms.RadioButton();
            this.rdbtnThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWherToEat = new System.Windows.Forms.GroupBox();
            this.rdbtnTakeOut = new System.Windows.Forms.RadioButton();
            this.rdbtnEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.lOrderSummaryHeader = new System.Windows.Forms.Label();
            this.lToppingsHeader = new System.Windows.Forms.Label();
            this.lCurstTypeHeader = new System.Windows.Forms.Label();
            this.lWhereToEatHeader = new System.Windows.Forms.Label();
            this.lTotalPriceHeader = new System.Windows.Forms.Label();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.lCursType = new System.Windows.Forms.Label();
            this.lSizeHeader = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.lToppings = new System.Windows.Forms.Label();
            this.lCrustType = new System.Windows.Forms.Label();
            this.lWhereToEat = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWherToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHeaderName
            // 
            this.lHeaderName.AutoSize = true;
            this.lHeaderName.Font = new System.Drawing.Font("Verdana", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeaderName.ForeColor = System.Drawing.Color.Red;
            this.lHeaderName.Location = new System.Drawing.Point(389, 40);
            this.lHeaderName.Name = "lHeaderName";
            this.lHeaderName.Size = new System.Drawing.Size(422, 52);
            this.lHeaderName.TabIndex = 0;
            this.lHeaderName.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rdbtnLarge);
            this.gbSize.Controls.Add(this.rdbtnMedium);
            this.gbSize.Controls.Add(this.rdbtnSmall);
            this.gbSize.Location = new System.Drawing.Point(96, 165);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 154);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.Location = new System.Drawing.Point(7, 115);
            this.rdbtnLarge.Name = "rdbtnLarge";
            this.rdbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbtnLarge.TabIndex = 2;
            this.rdbtnLarge.Text = "Large";
            this.rdbtnLarge.UseVisualStyleBackColor = true;
            this.rdbtnLarge.CheckedChanged += new System.EventHandler(this.rdbtnLarge_CheckedChanged);
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.Checked = true;
            this.rdbtnMedium.Location = new System.Drawing.Point(7, 67);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rdbtnMedium.TabIndex = 1;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Text = "Medium";
            this.rdbtnMedium.UseVisualStyleBackColor = true;
            this.rdbtnMedium.CheckedChanged += new System.EventHandler(this.rdbtnMedium_CheckedChanged);
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.Location = new System.Drawing.Point(6, 19);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbtnSmall.TabIndex = 0;
            this.rdbtnSmall.Text = "Small";
            this.rdbtnSmall.UseVisualStyleBackColor = true;
            this.rdbtnSmall.CheckedChanged += new System.EventHandler(this.rdbtnSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rdbtnThickCrust);
            this.gbCrustType.Controls.Add(this.rdbtnThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(96, 391);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 106);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rdbtnThickCrust
            // 
            this.rdbtnThickCrust.AutoSize = true;
            this.rdbtnThickCrust.Location = new System.Drawing.Point(7, 67);
            this.rdbtnThickCrust.Name = "rdbtnThickCrust";
            this.rdbtnThickCrust.Size = new System.Drawing.Size(79, 17);
            this.rdbtnThickCrust.TabIndex = 1;
            this.rdbtnThickCrust.Text = "Thick Crust";
            this.rdbtnThickCrust.UseVisualStyleBackColor = true;
            this.rdbtnThickCrust.CheckedChanged += new System.EventHandler(this.rdbtnThickCrust_CheckedChanged);
            // 
            // rdbtnThinCrust
            // 
            this.rdbtnThinCrust.AutoSize = true;
            this.rdbtnThinCrust.Checked = true;
            this.rdbtnThinCrust.Location = new System.Drawing.Point(6, 19);
            this.rdbtnThinCrust.Name = "rdbtnThinCrust";
            this.rdbtnThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rdbtnThinCrust.TabIndex = 0;
            this.rdbtnThinCrust.TabStop = true;
            this.rdbtnThinCrust.Text = "Thin Crust";
            this.rdbtnThinCrust.UseVisualStyleBackColor = true;
            this.rdbtnThinCrust.CheckedChanged += new System.EventHandler(this.rdbtnThinCrust_CheckedChanged);
            // 
            // gbWherToEat
            // 
            this.gbWherToEat.Controls.Add(this.rdbtnTakeOut);
            this.gbWherToEat.Controls.Add(this.rdbtnEatIn);
            this.gbWherToEat.Location = new System.Drawing.Point(499, 391);
            this.gbWherToEat.Name = "gbWherToEat";
            this.gbWherToEat.Size = new System.Drawing.Size(200, 73);
            this.gbWherToEat.TabIndex = 4;
            this.gbWherToEat.TabStop = false;
            this.gbWherToEat.Text = "Where To Eat";
            // 
            // rdbtnTakeOut
            // 
            this.rdbtnTakeOut.AutoSize = true;
            this.rdbtnTakeOut.Location = new System.Drawing.Point(131, 31);
            this.rdbtnTakeOut.Name = "rdbtnTakeOut";
            this.rdbtnTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rdbtnTakeOut.TabIndex = 1;
            this.rdbtnTakeOut.Text = "Take Out";
            this.rdbtnTakeOut.UseVisualStyleBackColor = true;
            this.rdbtnTakeOut.CheckedChanged += new System.EventHandler(this.rdbtnTakeOut_CheckedChanged);
            // 
            // rdbtnEatIn
            // 
            this.rdbtnEatIn.AutoSize = true;
            this.rdbtnEatIn.Checked = true;
            this.rdbtnEatIn.Location = new System.Drawing.Point(13, 31);
            this.rdbtnEatIn.Name = "rdbtnEatIn";
            this.rdbtnEatIn.Size = new System.Drawing.Size(53, 17);
            this.rdbtnEatIn.TabIndex = 0;
            this.rdbtnEatIn.TabStop = true;
            this.rdbtnEatIn.Text = "Eat In";
            this.rdbtnEatIn.UseVisualStyleBackColor = true;
            this.rdbtnEatIn.CheckedChanged += new System.EventHandler(this.rdbtnEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(499, 165);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(220, 154);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(114, 116);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(114, 68);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(114, 19);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 116);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 67);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(6, 19);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // lOrderSummaryHeader
            // 
            this.lOrderSummaryHeader.AutoSize = true;
            this.lOrderSummaryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrderSummaryHeader.Location = new System.Drawing.Point(878, 165);
            this.lOrderSummaryHeader.Name = "lOrderSummaryHeader";
            this.lOrderSummaryHeader.Size = new System.Drawing.Size(133, 20);
            this.lOrderSummaryHeader.TabIndex = 5;
            this.lOrderSummaryHeader.Text = "Order Summary";
            // 
            // lToppingsHeader
            // 
            this.lToppingsHeader.AutoSize = true;
            this.lToppingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToppingsHeader.Location = new System.Drawing.Point(879, 245);
            this.lToppingsHeader.Name = "lToppingsHeader";
            this.lToppingsHeader.Size = new System.Drawing.Size(81, 16);
            this.lToppingsHeader.TabIndex = 7;
            this.lToppingsHeader.Text = "Toppings: ";
            // 
            // lCurstTypeHeader
            // 
            this.lCurstTypeHeader.AutoSize = true;
            this.lCurstTypeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurstTypeHeader.Location = new System.Drawing.Point(879, 345);
            this.lCurstTypeHeader.Name = "lCurstTypeHeader";
            this.lCurstTypeHeader.Size = new System.Drawing.Size(90, 16);
            this.lCurstTypeHeader.TabIndex = 8;
            this.lCurstTypeHeader.Text = "Crust Type: ";
            // 
            // lWhereToEatHeader
            // 
            this.lWhereToEatHeader.AutoSize = true;
            this.lWhereToEatHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWhereToEatHeader.Location = new System.Drawing.Point(879, 376);
            this.lWhereToEatHeader.Name = "lWhereToEatHeader";
            this.lWhereToEatHeader.Size = new System.Drawing.Size(110, 16);
            this.lWhereToEatHeader.TabIndex = 9;
            this.lWhereToEatHeader.Text = "Where To Eat: ";
            // 
            // lTotalPriceHeader
            // 
            this.lTotalPriceHeader.AutoSize = true;
            this.lTotalPriceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPriceHeader.Location = new System.Drawing.Point(879, 446);
            this.lTotalPriceHeader.Name = "lTotalPriceHeader";
            this.lTotalPriceHeader.Size = new System.Drawing.Size(91, 16);
            this.lTotalPriceHeader.TabIndex = 10;
            this.lTotalPriceHeader.Text = "Total Price: ";
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lTotalPrice.Location = new System.Drawing.Point(981, 469);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(114, 61);
            this.lTotalPrice.TabIndex = 11;
            this.lTotalPrice.Text = "$30";
            // 
            // lCursType
            // 
            this.lCursType.AutoSize = true;
            this.lCursType.Location = new System.Drawing.Point(975, 345);
            this.lCursType.Name = "lCursType";
            this.lCursType.Size = new System.Drawing.Size(0, 13);
            this.lCursType.TabIndex = 17;
            // 
            // lSizeHeader
            // 
            this.lSizeHeader.AutoSize = true;
            this.lSizeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSizeHeader.Location = new System.Drawing.Point(879, 214);
            this.lSizeHeader.Name = "lSizeHeader";
            this.lSizeHeader.Size = new System.Drawing.Size(45, 16);
            this.lSizeHeader.TabIndex = 6;
            this.lSizeHeader.Text = "Size: ";
            // 
            // lSize
            // 
            this.lSize.Location = new System.Drawing.Point(925, 214);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(64, 13);
            this.lSize.TabIndex = 0;
            this.lSize.Text = "Medium";
            // 
            // lToppings
            // 
            this.lToppings.Location = new System.Drawing.Point(928, 272);
            this.lToppings.Name = "lToppings";
            this.lToppings.Size = new System.Drawing.Size(249, 59);
            this.lToppings.TabIndex = 0;
            this.lToppings.Text = "No Toppings";
            // 
            // lCrustType
            // 
            this.lCrustType.Location = new System.Drawing.Point(981, 348);
            this.lCrustType.Name = "lCrustType";
            this.lCrustType.Size = new System.Drawing.Size(114, 28);
            this.lCrustType.TabIndex = 18;
            this.lCrustType.Text = "Thin Crust";
            // 
            // lWhereToEat
            // 
            this.lWhereToEat.Location = new System.Drawing.Point(989, 405);
            this.lWhereToEat.Name = "lWhereToEat";
            this.lWhereToEat.Size = new System.Drawing.Size(106, 36);
            this.lWhereToEat.TabIndex = 19;
            this.lWhereToEat.Text = "Eat In";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(499, 473);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(109, 39);
            this.btnOrderPizza.TabIndex = 20;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(660, 473);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(109, 39);
            this.btnResetForm.TabIndex = 21;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 617);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.lWhereToEat);
            this.Controls.Add(this.lCrustType);
            this.Controls.Add(this.lToppings);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lCursType);
            this.Controls.Add(this.lTotalPrice);
            this.Controls.Add(this.lTotalPriceHeader);
            this.Controls.Add(this.lWhereToEatHeader);
            this.Controls.Add(this.lCurstTypeHeader);
            this.Controls.Add(this.lToppingsHeader);
            this.Controls.Add(this.lSizeHeader);
            this.Controls.Add(this.lOrderSummaryHeader);
            this.Controls.Add(this.gbWherToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lHeaderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWherToEat.ResumeLayout(false);
            this.gbWherToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHeaderName;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdbtnLarge;
        private System.Windows.Forms.RadioButton rdbtnMedium;
        private System.Windows.Forms.RadioButton rdbtnSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rdbtnThickCrust;
        private System.Windows.Forms.RadioButton rdbtnThinCrust;
        private System.Windows.Forms.GroupBox gbWherToEat;
        private System.Windows.Forms.RadioButton rdbtnTakeOut;
        private System.Windows.Forms.RadioButton rdbtnEatIn;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.Label lOrderSummaryHeader;
        private System.Windows.Forms.Label lToppingsHeader;
        private System.Windows.Forms.Label lCurstTypeHeader;
        private System.Windows.Forms.Label lWhereToEatHeader;
        private System.Windows.Forms.Label lTotalPriceHeader;
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Label lCursType;
        private System.Windows.Forms.Label lSizeHeader;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lToppings;
        private System.Windows.Forms.Label lCrustType;
        private System.Windows.Forms.Label lWhereToEat;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
    }
}

