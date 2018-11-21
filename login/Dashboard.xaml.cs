using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace login
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public class Product
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Path { get; set; }
        }

        List<Product> list = new List<Product>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            list.Add(new Product() { Name = "Thế Giới Phẳng - Thomas L. Friedman", Price = "204.000", Path = "../images/204.000 - Thế Giới Phẳng - Thomas L. Friedman.png" });
            list.Add(new Product() { Name = "Hài Hước Một Chút Thế Giới Sẽ Khác Đi - The Book Worm", Price = "36.000", Path = "../images/36.000 - Hài Hước Một Chút Thế Giới Sẽ Khác Đi - The Book Worm.png" });
            list.Add(new Product() { Name = "Phương Pháp Giáo Dục Con Của Người Do Thái - Trần Hân", Price = "37.200", Path = "../images/37.200 - Phương Pháp Giáo Dục Con Của Người Do Thái - Trần Hân.png" });
            list.Add(new Product() { Name = "Mình Là Cá, Việc Của Mình Là Bơi - Takeshi Furukawa", Price = "44.500", Path = "../images/44.500 - Mình Là Cá, Việc Của Mình Là Bơi - Takeshi Furukawa.png" });
            list.Add(new Product() { Name = "Đời Ngắn Đừng Ngủ Dài - Robin Sharma", Price = "47.000", Path = "../images/47.000 - Đời Ngắn Đừng Ngủ Dài - Robin Sharma.png" });
            list.Add(new Product() { Name = "Nghĩ Đơn Giản, Sống Đơn Thuần - Tolly Burkan", Price = "47.000", Path = "../images/47.000 - Nghĩ Đơn Giản, Sống Đơn Thuần - Tolly Burkan.png" });
            list.Add(new Product() { Name = "Đọc Vị Bất Kỳ Ai (Tái Bản) - TS. David J. Lieberman", Price = "48.000", Path = "../images/48.000 - Đọc Vị Bất Kỳ Ai (Tái Bản) - TS. David J. Lieberman.png" });
            list.Add(new Product() { Name = "Tuổi Trẻ Đáng Giá Bao Nhiêu - Rosie Nguyễn", Price = "49.000", Path = "../images/49.000 - Tuổi Trẻ Đáng Giá Bao Nhiêu - Rosie Nguyễn.png" });
            list.Add(new Product() { Name = "Đắc Nhân Tâm (Khổ Lớn) - Dale Carnegie", Price = "52.000", Path = "../images/52.000 - Đắc Nhân Tâm (Khổ Lớn) - Dale Carnegie.png" });
            list.Add(new Product() { Name = "Nhà Giả Kim - Paulo Coelho", Price = "55.000", Path = "../images/55.000 - Nhà Giả Kim - Paulo Coelho.png" });
            list.Add(new Product() { Name = "Nghệ Thuật Tinh Tế Của Việc Đếch Quan Tâm - Mark Manson", Price = "60.500", Path = "../images/60.500 - Nghệ Thuật Tinh Tế Của Việc Đếch Quan Tâm - Mark Manson.png" });
            list.Add(new Product() { Name = "Hành Trình Về Phương Đông (Tái Bản) - Baird T. Spalding", Price = "62.000", Path = "../images/62.000 - Hành Trình Về Phương Đông (Tái Bản) - Baird T. Spalding.png" });
            list.Add(new Product() { Name = "Khi Hơi Thở Hóa Thinh Không - Paul Kalanithi", Price = "76.000", Path = "../images/76.000 - Khi Hơi Thở Hóa Thinh Không - Paul Kalanithi.png" });
            list.Add(new Product() { Name = "Giết Con Chim Nhại (Tái Bản 2016) - Harper Lee", Price = "81.000", Path = "../images/81.000 - Giết Con Chim Nhại (Tái Bản 2016) - Harper Lee.png" });


            icProducts.ItemsSource = list;
        }
    }
}
