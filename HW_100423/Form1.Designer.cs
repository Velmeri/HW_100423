namespace HW_100423
{
	partial class Form1
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
			if (disposing && (components != null)) {
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
			this.GasStation = new System.Windows.Forms.GroupBox();
			this.GasOil = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.GasOilPrice = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rSum = new System.Windows.Forms.RadioButton();
			this.rCount = new System.Windows.Forms.RadioButton();
			this.tSum = new System.Windows.Forms.TextBox();
			this.tCount = new System.Windows.Forms.TextBox();
			this.tGasOilPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Cafe = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CafePrice = new System.Windows.Forms.Label();
			this.tColaCount = new System.Windows.Forms.TextBox();
			this.tColaPrice = new System.Windows.Forms.TextBox();
			this.tFrenchFryCount = new System.Windows.Forms.TextBox();
			this.tFrachFryPrice = new System.Windows.Forms.TextBox();
			this.tHamburgerCount = new System.Windows.Forms.TextBox();
			this.checkCola = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tHamburgerPrice = new System.Windows.Forms.TextBox();
			this.checkFrenchFry = new System.Windows.Forms.CheckBox();
			this.tHotDogCount = new System.Windows.Forms.TextBox();
			this.checkHamburger = new System.Windows.Forms.CheckBox();
			this.tHotDogPrice = new System.Windows.Forms.TextBox();
			this.checkHotDog = new System.Windows.Forms.CheckBox();
			this.Count = new System.Windows.Forms.Button();
			this.Total = new System.Windows.Forms.GroupBox();
			this.AllPrice = new System.Windows.Forms.Label();
			this.GasStation.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.Cafe.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.Total.SuspendLayout();
			this.SuspendLayout();
			// 
			// GasStation
			// 
			this.GasStation.Controls.Add(this.GasOil);
			this.GasStation.Controls.Add(this.groupBox2);
			this.GasStation.Controls.Add(this.groupBox1);
			this.GasStation.Controls.Add(this.tSum);
			this.GasStation.Controls.Add(this.tCount);
			this.GasStation.Controls.Add(this.tGasOilPrice);
			this.GasStation.Controls.Add(this.label4);
			this.GasStation.Controls.Add(this.label5);
			this.GasStation.Controls.Add(this.label3);
			this.GasStation.Controls.Add(this.label2);
			this.GasStation.Controls.Add(this.label1);
			this.GasStation.Location = new System.Drawing.Point(12, 12);
			this.GasStation.Name = "GasStation";
			this.GasStation.Size = new System.Drawing.Size(379, 305);
			this.GasStation.TabIndex = 0;
			this.GasStation.TabStop = false;
			this.GasStation.Text = "Автозаправка";
			// 
			// GasOil
			// 
			this.GasOil.Items.AddRange(new object[] {
            "А92",
            "А95"});
			this.GasOil.Location = new System.Drawing.Point(132, 36);
			this.GasOil.Name = "GasOil";
			this.GasOil.Size = new System.Drawing.Size(121, 24);
			this.GasOil.TabIndex = 6;
			this.GasOil.SelectedIndexChanged += new System.EventHandler(this.GasOil_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GasOilPrice);
			this.groupBox2.Location = new System.Drawing.Point(62, 197);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 89);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "До оплати";
			// 
			// GasOilPrice
			// 
			this.GasOilPrice.AutoSize = true;
			this.GasOilPrice.Location = new System.Drawing.Point(104, 55);
			this.GasOilPrice.Name = "GasOilPrice";
			this.GasOilPrice.Size = new System.Drawing.Size(0, 16);
			this.GasOilPrice.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rSum);
			this.groupBox1.Controls.Add(this.rCount);
			this.groupBox1.Location = new System.Drawing.Point(9, 102);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 89);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// rSum
			// 
			this.rSum.AutoSize = true;
			this.rSum.Location = new System.Drawing.Point(6, 47);
			this.rSum.Name = "rSum";
			this.rSum.Size = new System.Drawing.Size(71, 20);
			this.rSum.TabIndex = 2;
			this.rSum.Text = "Сумма";
			this.rSum.UseVisualStyleBackColor = true;
			// 
			// rCount
			// 
			this.rCount.AutoSize = true;
			this.rCount.Checked = true;
			this.rCount.Location = new System.Drawing.Point(6, 21);
			this.rCount.Name = "rCount";
			this.rCount.Size = new System.Drawing.Size(85, 20);
			this.rCount.TabIndex = 2;
			this.rCount.TabStop = true;
			this.rCount.Text = "Кількість";
			this.rCount.UseVisualStyleBackColor = true;
			this.rCount.CheckedChanged += new System.EventHandler(this.rCount_CheckedChanged);
			// 
			// tSum
			// 
			this.tSum.Location = new System.Drawing.Point(132, 151);
			this.tSum.Name = "tSum";
			this.tSum.ReadOnly = true;
			this.tSum.Size = new System.Drawing.Size(100, 22);
			this.tSum.TabIndex = 5;
			this.tSum.Text = "0";
			this.tSum.TextChanged += new System.EventHandler(this.tSum_TextChanged);
			// 
			// tCount
			// 
			this.tCount.Location = new System.Drawing.Point(132, 123);
			this.tCount.Name = "tCount";
			this.tCount.Size = new System.Drawing.Size(100, 22);
			this.tCount.TabIndex = 5;
			this.tCount.Text = "0";
			this.tCount.TextChanged += new System.EventHandler(this.tCount_TextChanged);
			// 
			// tGasOilPrice
			// 
			this.tGasOilPrice.Location = new System.Drawing.Point(132, 67);
			this.tGasOilPrice.Name = "tGasOilPrice";
			this.tGasOilPrice.ReadOnly = true;
			this.tGasOilPrice.Size = new System.Drawing.Size(100, 22);
			this.tGasOilPrice.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(238, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "л.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(238, 157);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "грг.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(238, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "грг.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ціна";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Бензин";
			// 
			// Cafe
			// 
			this.Cafe.Controls.Add(this.groupBox3);
			this.Cafe.Controls.Add(this.tColaCount);
			this.Cafe.Controls.Add(this.tColaPrice);
			this.Cafe.Controls.Add(this.tFrenchFryCount);
			this.Cafe.Controls.Add(this.tFrachFryPrice);
			this.Cafe.Controls.Add(this.tHamburgerCount);
			this.Cafe.Controls.Add(this.checkCola);
			this.Cafe.Controls.Add(this.label10);
			this.Cafe.Controls.Add(this.label9);
			this.Cafe.Controls.Add(this.tHamburgerPrice);
			this.Cafe.Controls.Add(this.checkFrenchFry);
			this.Cafe.Controls.Add(this.tHotDogCount);
			this.Cafe.Controls.Add(this.checkHamburger);
			this.Cafe.Controls.Add(this.tHotDogPrice);
			this.Cafe.Controls.Add(this.checkHotDog);
			this.Cafe.Location = new System.Drawing.Point(397, 12);
			this.Cafe.Name = "Cafe";
			this.Cafe.Size = new System.Drawing.Size(374, 305);
			this.Cafe.TabIndex = 0;
			this.Cafe.TabStop = false;
			this.Cafe.Text = "Міні-кафе";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CafePrice);
			this.groupBox3.Location = new System.Drawing.Point(66, 197);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(239, 89);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "До оплати";
			// 
			// CafePrice
			// 
			this.CafePrice.AutoSize = true;
			this.CafePrice.Location = new System.Drawing.Point(93, 55);
			this.CafePrice.Name = "CafePrice";
			this.CafePrice.Size = new System.Drawing.Size(0, 16);
			this.CafePrice.TabIndex = 3;
			// 
			// tColaCount
			// 
			this.tColaCount.Location = new System.Drawing.Point(245, 135);
			this.tColaCount.Name = "tColaCount";
			this.tColaCount.ReadOnly = true;
			this.tColaCount.Size = new System.Drawing.Size(100, 22);
			this.tColaCount.TabIndex = 5;
			this.tColaCount.Text = "0";
			this.tColaCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// tColaPrice
			// 
			this.tColaPrice.Location = new System.Drawing.Point(123, 133);
			this.tColaPrice.Name = "tColaPrice";
			this.tColaPrice.ReadOnly = true;
			this.tColaPrice.Size = new System.Drawing.Size(100, 22);
			this.tColaPrice.TabIndex = 5;
			this.tColaPrice.Text = "4,40";
			// 
			// tFrenchFryCount
			// 
			this.tFrenchFryCount.Location = new System.Drawing.Point(245, 107);
			this.tFrenchFryCount.Name = "tFrenchFryCount";
			this.tFrenchFryCount.ReadOnly = true;
			this.tFrenchFryCount.Size = new System.Drawing.Size(100, 22);
			this.tFrenchFryCount.TabIndex = 5;
			this.tFrenchFryCount.Text = "0";
			this.tFrenchFryCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// tFrachFryPrice
			// 
			this.tFrachFryPrice.Location = new System.Drawing.Point(123, 105);
			this.tFrachFryPrice.Name = "tFrachFryPrice";
			this.tFrachFryPrice.ReadOnly = true;
			this.tFrachFryPrice.Size = new System.Drawing.Size(100, 22);
			this.tFrachFryPrice.TabIndex = 5;
			this.tFrachFryPrice.Text = "7,20";
			// 
			// tHamburgerCount
			// 
			this.tHamburgerCount.Location = new System.Drawing.Point(245, 79);
			this.tHamburgerCount.Name = "tHamburgerCount";
			this.tHamburgerCount.ReadOnly = true;
			this.tHamburgerCount.Size = new System.Drawing.Size(100, 22);
			this.tHamburgerCount.TabIndex = 5;
			this.tHamburgerCount.Text = "0";
			this.tHamburgerCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// checkCola
			// 
			this.checkCola.AutoSize = true;
			this.checkCola.Location = new System.Drawing.Point(6, 135);
			this.checkCola.Name = "checkCola";
			this.checkCola.Size = new System.Drawing.Size(96, 20);
			this.checkCola.TabIndex = 4;
			this.checkCola.Text = "Кока-Кола";
			this.checkCola.UseVisualStyleBackColor = true;
			this.checkCola.CheckedChanged += new System.EventHandler(this.checkCola_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(263, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 16);
			this.label10.TabIndex = 3;
			this.label10.Text = "Кількість";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(154, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 16);
			this.label9.TabIndex = 3;
			this.label9.Text = "Ціна";
			// 
			// tHamburgerPrice
			// 
			this.tHamburgerPrice.Location = new System.Drawing.Point(123, 77);
			this.tHamburgerPrice.Name = "tHamburgerPrice";
			this.tHamburgerPrice.ReadOnly = true;
			this.tHamburgerPrice.Size = new System.Drawing.Size(100, 22);
			this.tHamburgerPrice.TabIndex = 5;
			this.tHamburgerPrice.Text = "5,40";
			// 
			// checkFrenchFry
			// 
			this.checkFrenchFry.AutoSize = true;
			this.checkFrenchFry.Location = new System.Drawing.Point(6, 107);
			this.checkFrenchFry.Name = "checkFrenchFry";
			this.checkFrenchFry.Size = new System.Drawing.Size(117, 20);
			this.checkFrenchFry.TabIndex = 4;
			this.checkFrenchFry.Text = "Картопля-Фрі";
			this.checkFrenchFry.UseVisualStyleBackColor = true;
			this.checkFrenchFry.CheckedChanged += new System.EventHandler(this.checkFrenchFry_CheckedChanged);
			// 
			// tHotDogCount
			// 
			this.tHotDogCount.Location = new System.Drawing.Point(245, 49);
			this.tHotDogCount.Name = "tHotDogCount";
			this.tHotDogCount.ReadOnly = true;
			this.tHotDogCount.Size = new System.Drawing.Size(100, 22);
			this.tHotDogCount.TabIndex = 5;
			this.tHotDogCount.Text = "0";
			this.tHotDogCount.TextChanged += new System.EventHandler(this.Cafe_Count_Changed);
			// 
			// checkHamburger
			// 
			this.checkHamburger.AutoSize = true;
			this.checkHamburger.Location = new System.Drawing.Point(6, 79);
			this.checkHamburger.Name = "checkHamburger";
			this.checkHamburger.Size = new System.Drawing.Size(99, 20);
			this.checkHamburger.TabIndex = 4;
			this.checkHamburger.Text = "Гамбургер";
			this.checkHamburger.UseVisualStyleBackColor = true;
			this.checkHamburger.CheckedChanged += new System.EventHandler(this.checkHamburger_CheckedChanged);
			// 
			// tHotDogPrice
			// 
			this.tHotDogPrice.Location = new System.Drawing.Point(123, 49);
			this.tHotDogPrice.Name = "tHotDogPrice";
			this.tHotDogPrice.ReadOnly = true;
			this.tHotDogPrice.Size = new System.Drawing.Size(100, 22);
			this.tHotDogPrice.TabIndex = 5;
			this.tHotDogPrice.Text = "4,00";
			// 
			// checkHotDog
			// 
			this.checkHotDog.AutoSize = true;
			this.checkHotDog.Location = new System.Drawing.Point(6, 49);
			this.checkHotDog.Name = "checkHotDog";
			this.checkHotDog.Size = new System.Drawing.Size(79, 20);
			this.checkHotDog.TabIndex = 4;
			this.checkHotDog.Text = "Хот-Дог";
			this.checkHotDog.UseVisualStyleBackColor = true;
			this.checkHotDog.CheckedChanged += new System.EventHandler(this.checkHotDog_CheckedChanged);
			// 
			// Count
			// 
			this.Count.Location = new System.Drawing.Point(46, 44);
			this.Count.Name = "Count";
			this.Count.Size = new System.Drawing.Size(156, 62);
			this.Count.TabIndex = 1;
			this.Count.Text = "Порахувати";
			this.Count.UseVisualStyleBackColor = true;
			this.Count.Click += new System.EventHandler(this.Count_Click);
			// 
			// Total
			// 
			this.Total.Controls.Add(this.AllPrice);
			this.Total.Controls.Add(this.Count);
			this.Total.Location = new System.Drawing.Point(27, 323);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(758, 112);
			this.Total.TabIndex = 3;
			this.Total.TabStop = false;
			this.Total.Text = "Всього до оплати";
			// 
			// AllPrice
			// 
			this.AllPrice.AutoSize = true;
			this.AllPrice.Location = new System.Drawing.Point(457, 67);
			this.AllPrice.Name = "AllPrice";
			this.AllPrice.Size = new System.Drawing.Size(30, 16);
			this.AllPrice.TabIndex = 3;
			this.AllPrice.Text = "грг.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 450);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.Cafe);
			this.Controls.Add(this.GasStation);
			this.Name = "Form1";
			this.Text = "GasOil";
			this.GasStation.ResumeLayout(false);
			this.GasStation.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Cafe.ResumeLayout(false);
			this.Cafe.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.Total.ResumeLayout(false);
			this.Total.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GasStation;
		private System.Windows.Forms.GroupBox Cafe;
		private System.Windows.Forms.Button Count;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkHotDog;
		private System.Windows.Forms.TextBox tGasOilPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rSum;
		private System.Windows.Forms.RadioButton rCount;
		private System.Windows.Forms.TextBox tSum;
		private System.Windows.Forms.TextBox tCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label GasOilPrice;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tColaCount;
		private System.Windows.Forms.TextBox tColaPrice;
		private System.Windows.Forms.TextBox tFrenchFryCount;
		private System.Windows.Forms.TextBox tFrachFryPrice;
		private System.Windows.Forms.TextBox tHamburgerCount;
		private System.Windows.Forms.CheckBox checkCola;
		private System.Windows.Forms.TextBox tHamburgerPrice;
		private System.Windows.Forms.CheckBox checkFrenchFry;
		private System.Windows.Forms.TextBox tHotDogCount;
		private System.Windows.Forms.CheckBox checkHamburger;
		private System.Windows.Forms.TextBox tHotDogPrice;
		private System.Windows.Forms.GroupBox Total;
		private System.Windows.Forms.Label AllPrice;
		private System.Windows.Forms.Label CafePrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox GasOil;
	}
}

