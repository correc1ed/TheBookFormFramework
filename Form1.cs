using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace TheBookFormFramework {
	public partial class TheBooksFramework {
		// Эти строки кода
		Random random = new Random();

		string[] BookNames = { "Как стать супер успешным", "Поверь в себя", "Будь дебилом", "Мир не важен, важен ты", "Атлант расправил плечи" };
		string[] AuthorNames = { "Айн Ренд", "Роберт Кийосаки", "Дейл Карнеги", "Ричард Бренсон", "Гай Навасаки", "Генри Форд" };
		string[] Valuations = { "Bad", "Secondary", "Good", "Very Good" };
		//нам понадобятся для случайного заполнения ввода данных.

		public TheBooksFramework() {
			InitializeComponent();
			TableOut();

		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			AddInTable();
		}

		void AddInTable() {
			try {
				using (var db = new BookContext()) {
					Book book = new Book { TheBookName = textTheBookName.Text, TheBookAuthor = textTheBookAuthor.Text, TheBookNumberOfPages = Convert.ToInt32(textTheBookNumberOfPages.Text), TheBookValuation = comboTheBookValuation.Text };

					db.Books.Add(book);
					db.SaveChanges();

					MessageBox.Show("Object saved completed.");

					TableOut();
				}
			} catch (Exception exception) {
				MessageBox.Show($"Ошибка: {exception}");
			}

		}
		void TableOut() {
			try {
				using (BookContext db = new BookContext()) {
					
					var books = db.Books.ToList();
					
					//Console.WriteLine("Objects list: ");
					//labelTableResult.Text = "Table: \n";

				    var listviewitem = new ListViewItem();
					new ColumnHeader();
					var listviewcollection = new ListViewItemCollection(listViewTable);


					foreach (Book b in books) {

						listviewitem.Text = $"{b.Id}";

						listviewcollection.Add();

						
							//просто не понимаю, как его из entity framework вывести.
						//я не расчитывал на то, что оно заработает. Просто по документации нихера не понятно, как сразу из бд вывести. 

						//labelTableOut.Text += $" \n {b.Id} {b.TheBookName} {b.TheBookAuthor} {b.TheBookNumberOfPages} {b.TheBookValuation}";
					}

				}
			} catch (Exception exceprion) {
				MessageBox.Show($"Ошибка: {exceprion.Message}");
			}


		}

		//void TableOut_()  // РЕШАЙ ТУТ, ЧТО ДЕЛАТЬ.
		//{
		//	try {
		//		using (BookContext db = new BookContext()) {
		//			var books = db.Books;


		//			foreach (Book b in books) {
		//				var listViewItem = new ListViewItem();

		//				listViewItem.Text = ($"{b.Id} {b.TheBookName} {b.TheBookAuthor} {b.TheBookNumberOfPages} {b.TheBookValuation}");




		//				listViewTable.Columns.Add(listViewItem);

		//			}
		//		}
		//	} catch (Exception exceprion) {
		//		MessageBox.Show($"Ошибка: {exceprion}");
		//	}
		//}

		private void buttonClear_Click(object sender, EventArgs e) {
			textTheBookName.Text = "";
			textTheBookAuthor.Text = "";
			textTheBookNumberOfPages.Text = "";
			comboTheBookValuation.Text = "";
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			try {
				using (BookContext db = new BookContext()) {
					Book deleted;
					switch (comboForDelete.Text) {
						case "Id": {
							deleted = new Book { Id = Convert.ToInt32(textforDelete.Text) };
							//что примечательно - тут проблем у меня проблем нет. 

							db.Books.Attach(deleted);
							db.Books.Remove(deleted);
							break;
						}
						case "Name": {

							deleted = db.Books.Where(x => x.TheBookName == textforDelete.Text).Single<Book>();
							db.Books.Remove(deleted);
							break;
						}
						case "Author": {

							deleted = db.Books.Where(x => x.TheBookAuthor == textforDelete.Text).Single<Book>();
							db.Books.Remove(deleted);
							break;
						}
						case "PageOfNumber": {
							int textDelete = Convert.ToInt32(textforDelete.Text);

							deleted = db.Books.Where(x => x.TheBookNumberOfPages == textDelete).Single<Book>();
							db.Books.Remove(deleted);
							break;
						}
						case "Valuation": {
							deleted = db.Books.Where(x => x.TheBookValuation == textforDelete.Text).Single<Book>();
							db.Books.Remove(deleted);
							break;
						}


					}

					db.SaveChanges();

					MessageBox.Show("Object delete completed!");

					TableOut();
				}
			} catch (Exception exception) { MessageBox.Show($"Ошибка: {exception.Message}"); }

		}

		private void buttonUPDATE_Click(object sender, EventArgs e) {
			try {
				using (BookContext db = new BookContext()) {
					switch (comboIN.Text) {
						case ("Id"): {
							var textin = Convert.ToInt32(textupdateIN.Text);

							var Update = db.Books.SingleOrDefault(b => b.Id == textin);
							if (Update != null) {

								UpdateHelper(Update);
								db.SaveChanges();

							}

							break;
						}
						case ("Name"): {
							var textinstring = textupdateIN.Text;

							var Update = db.Books.SingleOrDefault(b => b.TheBookName == textinstring); // проблема со строками.

							if (Update != null) {

								UpdateHelper(Update);
								db.SaveChanges();

							}

							break;
						}
						case ("Author"): {
							var textinstring = textupdateIN.Text;

							var Update = db.Books.SingleOrDefault(b => b.TheBookAuthor == textinstring);
							if (Update != null) {

								UpdateHelper(Update);
								db.SaveChanges();

							}

							break;
						}

						case ("PageOfNumber"): {
							var textin = Convert.ToInt32(textupdateIN.Text);


							var Update = db.Books.SingleOrDefault(b => b.TheBookNumberOfPages == textin);
							if (Update != null) {
								UpdateHelper(Update);
								db.SaveChanges();

							}

							break;
						}
						case ("Valuation"): {
							var textinstring = textupdateIN.Text;

							var Update = db.Books.SingleOrDefault(b => b.TheBookValuation == textinstring);
							if (Update != null) {

								UpdateHelper(Update);
								db.SaveChanges();

							}

							break;
						}



					}

					MessageBox.Show("File updated!");
				}
			} catch (Exception exception) { MessageBox.Show("Ошибка: " + exception.Message); }

			void UpdateHelper(Book update) {

				switch (comboOUT.Text) {
					case "Id":
						update.Id = Convert.ToInt32(textupdateOUT.Text);
						break;
					case "Name":
						update.TheBookName = textupdateOUT.Text;
						break;
					case "Author":
						update.TheBookAuthor = textupdateOUT.Text;
						break;
					case "PageOfNumber":
						update.TheBookNumberOfPages = Convert.ToInt32(textupdateOUT.Text);
						break;
					case "Valuation":
						update.TheBookValuation = textupdateOUT.Text;
						break;

				}
			}


			TableOut();
		}

		private void buttonRandomFill_Click(object sender, EventArgs e) {
			textTheBookName.Text = BookNames[random.Next(0, BookNames.Length)];
			textTheBookAuthor.Text = AuthorNames[random.Next(0, AuthorNames.Length)];
			textTheBookNumberOfPages.Text = (random.Next(123, 654)).ToString();
			comboTheBookValuation.Text = Valuations[random.Next(0, Valuations.Length)];

		}

		private void buttonClearForUpdate_Click(object sender, EventArgs e) {
			comboIN.Text = "";
			comboOUT.Text = "";

			textupdateIN.Text = "";
			textupdateOUT.Text = "";
		}

		private void buttonClearForDelete_Click(object sender, EventArgs e) {
			comboForDelete.Text = "";
			textforDelete.Text = "";
		}

		private void TheBooksFramework_Load(object sender, EventArgs e) {
			TableOut();
		}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			

			//on tut.
        }
    }

    public class Book {
		public int Id { get; set; }
		public string TheBookName { get; set; }
		public string TheBookAuthor { get; set; }
		public int TheBookNumberOfPages { get; set; }
		public string TheBookValuation { get; set; }
	}

	public class BookContext : DbContext {
		public BookContext()
			: base("DbConnection") { }
		public DbSet<Book> Books { get; set; }
	}


}
