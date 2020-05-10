namespace CppCLRWinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Collections::Generic;
	using namespace System::Text;

	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();

		}

	protected:

		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::DataGridView^ dataGridView1;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Column1;
	private: System::Windows::Forms::DataGridView^ dataGridView2;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Column2;

	protected:

	private:

		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code

		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			this->Column2 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(28, 178);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"button1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);
			// 
			// dataGridView1
			// 
			this->dataGridView1->AllowUserToAddRows = false;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(1) { this->Column1 });
			this->dataGridView1->Location = System::Drawing::Point(142, 77);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(209, 262);
			this->dataGridView1->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(389, 371);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(267, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Prieš paskutinis skaičius yra suma, o paskutinis vidurkis";
			// 
			// dataGridView2
			// 
			this->dataGridView2->AllowUserToAddRows = false;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(1) { this->Column2 });
			this->dataGridView2->Location = System::Drawing::Point(392, 77);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->Size = System::Drawing::Size(186, 262);
			this->dataGridView2->TabIndex = 3;
			// 
			// Column2
			// 
			this->Column2->HeaderText = L"Pertvarkytas";
			this->Column2->Name = L"Column2";
			// 
			// Column1
			// 
			this->Column1->HeaderText = L"Pradinis";
			this->Column1->Name = L"Column1";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(688, 459);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->button1);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
		List<double> vektorius;
	private: System::Void duomenys()
	{
		int* a = new int[100];
		Random^ rnd = gcnew Random();
		for (int i = 0; i < 100; i++)
		{
			a[i] = rnd->Next(-50, 50);
		}
		StreamWriter^ rf = gcnew StreamWriter("duomenys.txt");
		for (int i = 0; i < 100; i++)
		{
			rf->Write(a[i].ToString());
			rf->Write("\n");
		}
		rf->Close();
	}
	private: System::Void irasymas()
	{
		double* b = new double[100];
		//List<double> vektorius;
		array<String^>^ y = gcnew array<String^> (100);
		StreamReader^ df = gcnew StreamReader("duomenys.txt");
		for (int i = 0; i < 100; i++)
		{
			y[i] = df->ReadLine();
			b[i] = Convert::ToInt32(y[i]);
			vektorius.Add(b[i]);
		}
		df->Close();
	}
	private: System::Void Pertvarka()
	{
		List<double> vekt;
		for (int i = 0; i < vektorius.Count; i++)
		{
			vekt.Add(vektorius[i]);
		}
		double s = 0, x=0;
		double vid = 0;
		for (int i = 0; i < vektorius.Count; i++)
		{
			dataGridView1->Rows->Add(vektorius[i].ToString());
		}
		for (int i = 0; i < vektorius.Count; i++)
		{
			if (vekt[i] < 0)
			{
				x++;
				s = s + vekt[i];
			}
		}
		vid = s / x;
		for (int i = 0; i < vekt.Count; i++)
		{
			if (vekt[i] < 0)
			{
				vekt[i] = vekt[i] / vid;
			}
		}
		s = 0;
		vid = 0;
		x = 0;
		for (int i = 0; i < vekt.Count; i++)
		{
			s = vekt[i] + s;
			x++;
		}
		vid = s / x;
		vekt.Add(s);
		vekt.Add(vid);
		for (int i = 0; i < vekt.Count; i++)
		{
			dataGridView2->Rows->Add(vekt[i].ToString());
		}
	}
	private: System::Void Form1_Load(System::Object^ sender, System::EventArgs^ e)
	{

	}
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e)
	{
		dataGridView1->Rows->Clear();
		vektorius.Clear();
		duomenys();
		irasymas();
		Pertvarka();

	}

	};
}
