# Thiết kế màn hình đăng nhập cơ bản để người dùng nhập Username và Password. (9 điểm)

- [x] Hai label: Username và Password cần được binding với hai textbox tương ứng khi bấm Alt + U (Username textbox sẽ nhận focus) và Alt + P (Passsword textbox sẽ nhận focus) (Check file WPF 02 Basic controls, slide 2)

- [x] Cần kiểm tra và hiện thông báo khi không có username và password.

- [x] Code cứng kiểm tra nếu username / password là admin / 123 thì chuyển sang màn hình dashboard và ẩn đi màn hình Login. Nếu không đúng thì hiện thông báo "Thông tin đăng nhập chưa đúng".

🤞 **1 điểm: Làm thêm yêu cầu sau đây:**

Tham khảo thiết kế từ pinterest (search với từ khóa login) và tạo ra giao diện đăng nhập tốt hơn 

# Tiếp tục bài tập lần trước, sau khi login thành công ở màn hình Dashboard, xây dựng như sau:

- [ ] Hiển thị lưới sản phẩm gồm 3 cột, 14 sản phẩm với 3 thông tin cơ bản: Giá, Tên sản phẩm, Hình ảnh của sản phẩm.

Cần chuẩn bị sẵn hình, tên, và giá lưu trong mảng (code cứng trước, sau này bổ sung nạp từ csdl lên sau)

- [ ] Chú ý giá sản phẩm phải đè lên góc trên bên phải của hình sản phẩm và tên sản phẩm nằm ngay dưới hình. (Gợi ý: chỉnh cho text màu đen có độ trong suốt alpha, chữ trắng, nếu được thì tốt còn không thì thôi)

- [ ] Mỗi item cần binding để hiển thị lên lưới.

- [ ] Tham khảo về ListView để hiển thị đanh sách ở đây: https://www.wpf-tutorial.com/listview-control/simple-listview/

## Giao diện
![](https://user-images.githubusercontent.com/32817908/48627783-09267580-e9e8-11e8-8261-885dcf2f538c.png)

## Hướng dẫn sử dụng
Tải về **2 tập**: `login.exe` và `FluentWPF.dll` (trong cùng 1 thư mục)

Chạy `login.exe`

## Thao khảo
Tài liệu giáo khoa, _Thầy Trần Duy Quang_

Open source FluentWPF: https://github.com/sourcechord/FluentWPF

QA: <br>
https://social.msdn.microsoft.com/Forums/sqlserver/en-US/e73f7d09-11ef-45f4-99c1-24e9e42eb7cf/button-mouseover-event-hides-the-buttons-background-image?forum=wpf<br>
https://stackoverflow.com/questions/8243181/using-uniformgrid-to-arrange-buttons-in-a-square

## Thực hiện 
1612291 - Nguyễn Thị Ngân Khánh
