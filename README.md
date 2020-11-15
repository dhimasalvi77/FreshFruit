# FRESH FRUIT 
Fresh Fruit adalah sebuah aplikasi yang digunakan untuk menambahkan buah-buahan kedalam sebuah keranjang yang mana keranjang tersebut dapat dibatasi kapasistasnya , Pada Aplikasi ini juga terdapat konsep MVC (Model View Controller).

## SCOPE & FUNCTIONALITIES
User dapat menekan tombol Add untuk menambahkan buah/fruit yang diinginkan
User dapat melihat nama buah yang sudah di ADD kedalam keranjang (Listbox)

### HOW DOES IT WORKS?
Pada Method Fruit.cs itu merupakan Logic View yang digunakan untuk menampilkan nama buah pada listbox. berikut merupakan source codenya

    public string name { get; set; }

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
logic model bisnis pada MainWindow.xaml.cs digunakan untuk menambahkan buah dengan cara menekan tombol ADD pada setiap gambar , dan menampilkannya pada listbox melalui method Fruit.cs. berikut merupakan source code pada MainWindow.xaml.cs

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            toni.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("apple");
            toni.addFruit(apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("banana");
            toni.addFruit(pisang);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("orange");
            toni.addFruit(orange);

            ListBoxBucket.Items.Refresh();
        }
