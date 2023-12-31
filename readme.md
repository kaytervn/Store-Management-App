**ĐỀ TÀI CUỐI KÌ MÔN HỆ QUẢN TRỊ CSDL**

**Quản lý cửa hàng tiện lợi**

# <a name="_toc134389916"></a>**MỤC LỤC** 
[LỜI CẢM ƠN	1****](#_toc134397050)**

[**LỜI NÓI ĐẦU	2****](#_toc134397051)

[**CHƯƠNG 1: TỔNG QUAN VỀ HỆ THỐNG	3****](#_toc134397052)

[**1.1. Mô tả bài toán	3****](#_toc134397053)

[**1.2. Nghiệp vụ	5****](#_toc134397054)

[**1.2.1 Đối với nhân viên	5****](#_toc134397055)

[**1.2.2 Đối với quản lý	6****](#_toc134397056)

[**1.3. Mô tả các chức năng	7****](#_toc134397057)

[**1.4. Cách tính lương nhân viên, doanh thu cửa hàng, điểm tích lũy	7****](#_toc134397058)

[**CHƯƠNG 2: PHÂN TÍCH THIẾT KẾ HỆ THỐNG	9****](#_toc134397059)

[**2.1 Thiết kế cơ sở dữ liệu mức quan niệm	9****](#_toc134397060)

[**2.2 Thiết kế cơ sở dữ liệu mức logic	10****](#_toc134397061)

[**2.3 Các ràng buộc cần có	11****](#_toc134397062)

[**2.4. Cài đặt CSDL và các ràng buộc	12****](#_toc134397063)

[**2.4.1 Tạo bảng và các ràng buộc đơn giản	12****](#_toc134397064)

[**2.4.2 Trigger kiểm tra các ràng buộc	15****](#_toc134397065)

[**2.4.3 Các view	16****](#_toc134397066)

[**CHƯƠNG 3: THIẾT KẾ CÁC CHỨC NĂNG	18****](#_toc134397067)

[**3.1 Kết nối cơ sở dữ liệu	18****](#_toc134397068)

[**3.2 Các thủ tục, hàm	19****](#_toc134397069)

[**3.2.1 Thông tin nhân viên	19****](#_toc134397070)

[**3.2.2 Thông tin nhà sản xuất	22****](#_toc134397071)

[**3.2.3 Sản phẩm	22****](#_toc134397072)

[**3.2.4 Kho	23****](#_toc134397073)

[**3.2.5 Cửa hàng	24****](#_toc134397074)

[**3.2.6 Khách Hàng	25****](#_toc134397075)

[**3.2.7 Ngày lễ	26****](#_toc134397076)

[**3.2.8 Hóa đơn	26****](#_toc134397077)

[**3.2.9 Thông tin chi tiết hóa đơn	27****](#_toc134397078)

[**3.2.10 Thông tin phân công	28****](#_toc134397079)

[**3.2.11 Hàm tính doanh thu	29****](#_toc134397080)

[**3.2.12 Hàm lọc doanh thu	29****](#_toc134397081)

[**3.2.13 Thủ tục Update lại cửa hàng khi thanh toán	29****](#_toc134397082)

[**3.2.14 Thủ tục UpdateGioBD	30****](#_toc134397083)

[**3.2.15 Thủ tục UpdateGioKT	30****](#_toc134397084)

[**3.2.16 Hàm Tính Lương một Chấm Công	30****](#_toc134397085)

[**3.2.17  Lương	31****](#_toc134397086)

[**3.2.18 Hàm bảng chi tiết hóa đơn thanh toán	32****](#_toc134397087)

[**3.2.19 Hàm tính MaxHD	32****](#_toc134397089)

[**CHƯƠNG 4: TẠO USER VÀ PHÂN QUYỀN	32****](#_toc134397090)

[**CHƯƠNG 5: THIẾT KẾ GIAO DIỆN HỆ THỐNG	34****](#_toc134397091)

[**5.1 Form đăng nhập	34****](#_toc134397092)

[**5.2 Form home	35****](#_toc134397093)

[**5.3 Thao tác đăng nhập	35****](#_toc134397094)

[**5.4 Các hàm kết nối và gọi thực thi chung từ SQL	37****](#_toc134397095)

[**5.5 Các hàm gọi thủ tục, hàm, view từ SQL trong lớp DAO (Data Access Object)	38****](#_toc134397096)

[**5.5.1 Ca	38****](#_toc134397097)

[**5.5.2 Chấm công	38****](#_toc134397098)

[**5.5.3 Chi tiết hóa đơn	39****](#_toc134397099)

[**5.5.4 Chức vụ	40****](#_toc134397100)

[**5.5.5 Cửa hàng	40****](#_toc134397101)

[**5.5.6 Hóa đơn	42****](#_toc134397102)

[**5.5.7 Khách hàng	43****](#_toc134397103)

[**5.5.8 Kho	44****](#_toc134397104)

[**5.5.9 Ngày lễ	45****](#_toc134397105)

[**5.5.10 Nhân viên	46****](#_toc134397106)

[**5.5.11 Nhà sản xuất	48****](#_toc134397107)

[**5.5.12 Phân công	49****](#_toc134397108)

[**5.5.13 Phương thức thanh toán	50****](#_toc134397109)

[**5.5.14 Sản phẩm	50****](#_toc134397110)

[**5.5.15 Tính lương	52****](#_toc134397111)

[**5.6 Các form danh mục	52****](#_toc134397112)

[**5.6.1 Đăng nhập với tư cách là nhân viên	52****](#_toc134397113)

[**5.6.2 Đăng nhập với tư cách là quản lý	58****](#_toc134397114)


**




<a name="_toc134397050"></a>**LỜI CẢM ƠN**

Lời đầu tiên, chúng em xin gửi lời cảm ơn sâu sắc đến thầy Nguyễn Thành Sơn vì sự hướng dẫn tận tình và giúp đỡ chúng em hoàn thành bài báo cáo cuối kì bộ môn Hệ quản trị cơ sở dữ liệu này. Nhờ những kiến thức thầy truyền đạt mà chúng em đã nắm chắc hơn được những kiến thức căn bản, nền tảng cho việc khi xây dựng một hệ thống quản trị cơ sở dữ liệu. Thông qua đồ án này, nhóm em xin trình bày lại quá trình phát triển của một hệ thống quản trị cơ sở dữ liệu, cũng như lập trình một đồ án liên quan. Trong quá trình thực hiện đồ án môn học, khó tránh khỏi những sai sót. Do đó nhóm chúng em rất mong sự góp ý đến từ thầy để bài làm của nhóm chúng em được hoàn thiện hơn, phát triển và đầy đủ hơn. Kính chúc thầy sức khỏe, hạnh phúc thành công trên con đường sự nghiệp giảng dạy. Cuối cùng chúng em xin chân thành cảm ơn các thầy và các bạn cùng tham gia học bộ môn Hệ quản trị cơ sở dữ liệu đã nhiệt tình giúp đỡ động viên chúng em trong trình thực hiện đồ án cuối kỳ.



<a name="_toc134389917"></a><a name="_toc134397051"></a>**LỜI NÓI ĐẦU**

Ngày nay, với sự phát triển mạnh mẽ của kinh tế xã hội đi đôi với nhu cầu cấp thiết của con người thì việc xuất hiện các ứng dụng về khoa học kỹ thuật là vô cùng quan trọng. Và để giúp cho các ứng dụng khoa học kỹ thuật phát triển thì không thể phủ nhận vai trò của công nghệ thông tin. Trong những năm gần đây, ngành công nghệ thông tin ngày càng có xu hướng trở nên phổ biến và cần thiết. Bởi vì bất kể lĩnh vực hay ngành nghề nào đều có ứng dụng của công nghệ thông tin. Vì thế, công nghệ thông tin đã và đang đóng vai trò quan trọng trong đời sống kinh tế, xã hội hằng ngày của chúng ta.

`	`Và với sự phát triển vượt bậc đó, thì không thể phủ nhận được rằng chính việc quản lý dữ liệu, thông tin của công nghệ thông tin đã giúp cho các doanh nghiệp, công ty tiết kiệm được hàng ngàn chi phí thống kê và dễ dàng kiểm soát trong kinh doanh. Đặc biệt, là cho các chủ cửa hàng có thể dễ dàng trong việc kiểm soát nhân viên, quá trình làm việc, lương,... từ xa thông qua các phần mềm quản lý trên hệ thống. Điều đó đạt hiệu quả rõ rệt khi giảm tối thiểu được chi phí nhân lực, thời gian cũng như tránh sai sót hay thiếu dữ liệu so với quản lý bằng giấy như trước đây.

`	`Chính vì những lý do đó, ứng dụng của Công nghệ thông tin đối với công tác quản lý thông tin, nhân viên trong cửa hàng đóng vai trò hết sức quan trọng. Và để làm rõ hơn về ứng dụng của Công nghệ thông tin ứng với công tác quản lý trong thực tế thì nhóm em lựa chọn đề tài “Quản lý cửa hàng tiện lợi” để nghiên cứu và phát triển ứng dụng của việc quản lý hệ thống dữ liệu trong môn học Hệ quản trị cơ sở dữ liệu.



<a name="_toc134389918"></a><a name="_toc134397052"></a>**CHƯƠNG 1: TỔNG QUAN VỀ HỆ THỐNG**

<a name="_toc134389919"></a><a name="_toc134397053"></a>**1.1. Mô tả bài toán**

<a name="_toc134389920"></a>Ở bài đồ án lần này, chúng tôi lựa chọn đề tài xây dựng chương trình quản lý cửa hàng tiện lợi. Cửa hàng tiện lợi cung cấp cho mỗi nhân viên một tài khoản, mỗi tài khoản được phân quyền với các chức năng và nghiệp vụ khác nhau tùy vào chức vụ của từng nhân viên, trong đó tài khoản Admin được quản lý toàn quyền của chương trình. Các hoạt động cơ bản của chương trình ứng dụng có thể kể đến như là quản lý sản phẩm, quản lý nhân sự, thanh toán và thống kê doanh thu. Một hệ thống quản lý cửa hàng tiện lợi cần lưu trữ những dữ liệu như sau:

Cửa hàng có nhiều nhân viên, mỗi nhân viên sẽ có mã nhân viên để phân biệt, nhân viên còn có các thông tin cá nhân như họ tên, tuổi tác, giới tính, ngày sinh, số điện thoại và email. Nhân viên phân công đảm nhiệm một chức vụ và có hoạt động chấm công với mỗi ngày làm việc tùy theo ca mà mình đăng ký, nhân viên có thể đăng ký nhiều ca.

Ngoài ra mỗi nhân viên có một tài khoản bao gồm tên tài khoản và mật khẩu để đăng nhập vào hệ thống. Mỗi nhân viên sẽ có chức vụ và quyền hạn khác nhau nên sẽ có tài khoản tương ứng và phân quyền khác nhau.

Ca làm việc bao gồm năm ca là ca sáng, ca trưa, ca chiều, ca tối và ca đêm. Mỗi ca phân biệt bằng mã ca và loại ca, có giờ bắt đầu và giờ kết thúc. Các ca làm việc có thể được mô tả như sau:

a. **Ca A** (06h -10h) 

b. **Ca B** (10h -14h) 

c. **Ca C** (14h -18h) 

d. **Ca D** (18h - 22h) 

e. **Ca E** (22h - 06h) 

Mỗi chức vụ có mã chức vụ và tên của chức vụ đó. Một nhân viên có thể đảm nhận các chức vụ sau: Nhân viên: Full-time, Part-time; Quản lý và Chủ cửa hàng - Người sử dụng tài khoản Admin.

`	`Hoạt động đăng ký ca được diễn ra liên tục, mỗi nhân viên bắt buộc phải thực hiện đăng ký phần ca làm để hệ thống ghi nhận. Thông tin phân công đăng ký ca bao gồm các thông tin như mã phân công để phân biệt, mã nhân viên, mã ca và ngày đăng ký. Nhân viên chỉ được đăng ký phần ca làm vào tương lai (kể từ ngày hôm sau trở đi).

Mỗi ngày làm việc của nhân viên đều phải ghi nhận hoạt động chấm công. Thông tin của mỗi lần chấm công bao gồm mã phân công, giờ bắt đầu, giờ kết thúc và lương trong số giờ đã làm ở ca đó.

`	`Ngoài ra, mỗi nhân viên được tính lương theo giờ của ca. Tùy vào từng chức vụ, loại ca đăng ký, số giờ đã làm trong ca đó mà mức lương của mỗi nhân viên có thể khác nhau. Sau một ngày làm việc và hoàn thành chấm công đầy đủ, lương của nhân viên sẽ được tổng kết vào cuối ngày. Tính lương bao gồm các thông tin như lương theo giờ, lương cuối ngày và lương thưởng (nếu có). Mức lương có thể được tính như sau:

`	`a. **Ca ngày:** (ca A, B, C, D)

**+ Đối với chức vụ nhân viên part-time:** 23.000 đồng/ giờ.

**+ Đối với bảo vệ:** 25.000 đồng/ giờ.

**+ Đối với nhân viên full-time:** 30.000 đồng/ giờ.

**+ Đối với quản lý:** 40.000 đồng/ giờ.

`	`b. **Ca đêm:** Được cộng thêm 25% so với ca ngày (ca E).

**Lương thưởng:**	

**- Quyền lợi khi làm vào các dịp Lễ/ Tết:** Lương x 3.

Thông tin của ngày Lễ/ Tết bao gồm mã ngày lễ, tên sự kiện, và ngày diễn ra.

Mỗi sản phẩm có mã sản phẩm, tên sản phẩm, giá gốc, giá bán, mã nhà sản xuất, mã loại, trạng thái, hình ảnh sản phẩm. Mỗi loại sản phẩm sẽ có mã loại và tên loại sản phẩm. Mỗi sản phẩm sẽ có nhà sản xuất cung cấp cho cửa hàng đó, nhà sản xuất gồm mã nhà sản xuất, tên nhà sản xuất, địa chỉ nhà sản xuất. Mỗi sản phẩm sẽ thuộc duy nhất một loại sản phẩm trong cửa hàng và được duy nhất một nhà sản xuất cung cấp. 

Kho của cửa hàng sẽ gồm có loại kho (kho lạnh và kho thường), ngày nhập kho, mã sản phẩm được lưu trữ trong kho, số lượng tồn kho của những sản phẩm đó, ngoài ra còn có các thông tin như hạn sử dụng, ngày sản xuất của những sản phẩm được lưu trữ trong đó.

Cửa hàng gồm những mã sản phẩm được đưa ra bày bán, ngày xuất kho, ngày sản xuất, hạn sử dụng và số lượng những sản phẩm đó.

Khách hàng sẽ có thể được thanh toán nhiều hóa đơn. Mỗi khách hàng có tên khách hàng, số điện thoại và điểm tích lũy. Mỗi hóa đơn gồm có mã hóa đơn, ngày thanh toán, mã nhân viên thanh toán cho khách hàng đó, số điện thoại khách hàng được thanh toán, phương thức thanh toán và tổng tiền thanh toán của hóa đơn đó . Mỗi hóa đơn có chi tiết hóa đơn, lưu số lượng, thành tiền và tiền lời tính được.

<a name="_toc134397054"></a>**1.2. Nghiệp vụ**

<a name="_toc134397055"></a>**1.2.1 Đối với nhân viên**

*Xem thông tin cá nhân*

`	`Nhân viên có thể xem thông tin cá nhân của bản thân và có thể đăng tải và lưu ảnh đại diện của mình.

*Thanh toán*

`	`Nghiệp vụ thanh toán bao gồm các bước sau:

**Bước 1:** Tạo hóa đơn thanh toán.

**Bước 2:** Chọn các sản phẩm có sẵn trong cửa hàng để Order cho hóa đơn, lưu lại thông tin số điện thoại của khách hàng (Nếu khách hàng đã đăng ký thành viên) để tích điểm.

**Bước 3:** Thanh toán hoặc hủy hóa đơn nếu có sai sót.

*Đăng ký công ca và chấm công*

`	`Nhân viên chọn ca làm và ngày mà mình muốn đăng ký, có thể xóa đăng ký và đăng ký lại. Tới ngày làm việc sẽ có hoạt động chấm công. Check in và check out đúng giờ trong ca đã đăng ký sẽ hiện lương của ca làm đó.

*Quản lý khách hàng*

`	`Nhân viên lưu trữ thông tin đăng ký thành viên của khách hàng, có các thủ tục như thêm, sửa, xóa và có thể xem các hóa đơn mà khách hàng đã đặt trước đó.

<a name="_toc134397056"></a>**1.2.2 Đối với quản lý**

*Quản lý nhân viên*

`	`Quản lý quản lý toàn bộ thông tin của nhân viên và có các thủ tục cơ bản như tìm kiếm, thêm, xóa và sửa nhân viên.

*Quản lý khách hàng*

Tương tự như nghiệp vụ quản lý khách hàng của nhân viên.

*Quản lý nhập kho*

Quản lý thông tin nhà sản xuất mà cửa hàng hợp tác.

Quản lý các sản phẩm mà cửa hàng đăng ký bày bán. Có thủ tục thêm, xóa, sửa.

Thao tác nhập kho: Chọn sản phẩm muốn nhập kho từ danh sách sản phẩm và nhập số lượng cần nhập kho.

*Quản lý xuất kho*

Thao tác xuất kho: Chọn sản phẩm muốn xuất kho từ danh sách sản phẩm trong kho để xuất hàng ra cửa hàng, lựa chọn số lượng phù hợp.

*Quản lý phân công*

Tương tự như nghiệp vụ đăng ký công ca và chấm công của nhân viên. Nhưng người quản lý có thể xem và thao tác trên toàn bộ nhân viên, bên cạnh đó người quản lý còn có thể quản lý những ngày lễ và chỉnh sửa thông tin ngày lễ trong tương lai.

*Quản lý lương*

Xem và thống kê bảng lương của toàn bộ nhân viên theo ngày.




*Quản lý doanh thu*

Theo dõi doanh thu từ toàn bộ hóa đơn đã thanh toán của cửa hàng. Lọc doanh thu và xem được tổng tiền lời nhận được từ một khoảng thời gian từ ngày mấy đến ngày mấy.

<a name="_toc134389921"></a><a name="_toc134397057"></a>**1.3. Mô tả các chức năng**

*Người quản lý - Người quản tị:*

Người quản lý có thể truy cập vào xem thông tin cá nhân của nhân viên: Toàn quyền với nhân viên và sản phẩm. Người quản trị có thể xem thông tin tài khoản và thay đổi mật khẩu.

*Nhân viên cửa hàng:*

Thêm, xóa sửa tài khoản tích lũy của khách hàng, có thể thanh toán cho từng hóa đơn, xuất hóa đơn. Phân quyền: “Chủ cửa hàng” toàn quyền với hệ thống. “Người quản lý” quản lý một phần quyền với hệ thống. “Nhân viên” không thể tham gia vào quyền của tài khoản khác.

<a name="_toc134389922"></a><a name="_toc134397058"></a>**1.4. Cách tính lương nhân viên, doanh thu cửa hàng, điểm tích lũy**

- *Tính tiền cho hóa đơn được tính:*

Tiền hóa đơn: Tổng tiền các sản phẩm 

- *Tổng doanh thu cửa hàng được tính:*

`	`Tổng doanh thu = Tổng tiền các hóa đơn 

- *Tính tổng tiền lời:*

Tổng tiền lời của một hóa đơn = Tổng tiền lời của các sản phẩm trong hóa đơn.

Tiền lời một sản phẩm sau khi bán = (Giá bán - Giá gốc) x SL.

- *Tính điểm tích lũy cho khách hàng:*

  Điểm tích lũy: Khách hàng được cộng điểm tích lũy bằng 1% dựa trên tổng hóa đơn

1000 điểm = 1.000 VND

- *Tính lương nhân viên được tính:*

Lương nhân viên dựa vào ngày, mã chức vụ, mã ca, mã ngày lễ để tính.

Đối với chức vụ nhân viên part-time: 23.000 đồng/ giờ.

Đối với nhân viên full-time: 30.000 đồng/ giờ.

Đối với bảo vệ: 25.000 đồng/ giờ 

Đối với quản lý: 40.000 đồng/ giờ 

***Ví dụ:*** 

- Một nhân part-time làm 2 ca gồm 4 tiếng ca A, và 6 tiếng E trong 1 ngày bình thường (không phải ngày lễ) sẽ được tính như sau:

Lương = 4 x 23.000 + 6 x 23.000 x 1.25 = 264.500 đồng.

Nếu làm trong ngày lễ:

`		`Lương = (4 x 23.000 + 6 x 23.000 x 1.25) x 3 = 793.500 đồng.

- Một quản lý sẽ làm full-time 1 ngày (ca A, B):

  `	`Lương = 8 \* 30.000 = 240.000 đồng

`	`Nếu làm trong ngày lễ:

`	`Lương = (8 \* 30.000) x3 = 720.000 đồng



<a name="_toc134389923"></a><a name="_toc134397059"></a>**CHƯƠNG 2: PHÂN TÍCH THIẾT KẾ HỆ THỐNG**

<a name="_toc134389924"></a><a name="_toc134397060"></a>**2.1 Thiết kế cơ sở dữ liệu mức quan niệm**

Từ mô tả về dữ liệu cần có ở phần mô tả bài toán, hình thành được sơ đồ thực thể kết hợp (ERD).

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.004.png)

<a name="_toc134389925"></a><a name="_toc134397061"></a>**2.2 Thiết kế cơ sở dữ liệu mức logic**

Từ sơ đồ thực thể kết hợp (ERD), ta có các lược đồ quan hệ:

**CHUCVU** (MaCV, TenCV, LuongTheoGio)

**NHANVIEN** (MaNV, TenNV, Sdt, Phai, NgaySinh, Email, MaCV, TrangThai, TenTK, MatKhau, Hình)

**NHASANXUAT** (MaNSX, TenNSX, DiaChi)

**LOAISANPHAM** (MaLoai, TenLoai)

**SANPHAM** (MaSP, TenSP, MaNSX, MaLoai, GiaBan, GiaGoc, TrangThai, Hinh)

**KHO** (MaSP, NSX, HSD, NgayNhapKho, LoaiKho, SLTonKho)

**CUAHANG** (MaSP, NSX, HSD, NgayXuatKho, SoLuong)

**KHACHHANG** (Sdt, TenKH, DiemTichLuy)

**NGAYLE** (MaNL, Ngay, SuKien)

**HOADON** (MaHD, MaNV, SdtKH, PTTT, Ngay, TongTienTT, TongTienLoi)

**CHITIETHOADON** (MaHD, MaSP, NSX, HSD, SoLuong, GiaBan, GiaGoc, ThanhTien, TienLoi)

**CA** (MaCa, LoaiCa, GioBatDau, GioKetThuc)

**PHANCONG** (MaPC, MaNV, MaCa, NgayDangKy)

**CHAMCONG** (MaPC, GioBD, GioKT, Luong)

**TINHLUONG** (MaNV, Ngay, TongLuong)

**PHUONGTHUCTHANHTOAN**(PTTT, TenPTTT)

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.005.png)

<a name="_toc134389926"></a><a name="_toc134397062"></a>**2.3 Các ràng buộc cần có**

|**STT**|**Bảng**|**Ràng buộc**|
| :-: | :-: | :-: |
|1|Chucvu|Khoá chính **MaCV** |
|2|NhanVien|<p>Khóa chính **MaNV**</p><p>Khóa ngoại **MaCV** tham chiếu đến MaCV (ChucVu)</p>|
|3|NhaSanXuat|Khóa chính **MaNSX**|
|4|LoaiSanPham|Khóa chính **MaLoai**|
|5|SanPham|<p>Khóa chính **MaSP**</p><p>Khóa ngoại **MaNSX**, **MaLoai** tham chiếu đến  MaNSX (NhaSanXuat), MaLoai (LoaiSanPham)</p>|
|6|Kho|<p>Khóa chính **MaSP, NSX, HSD**</p><p>Khóa ngoại **MaSP** tham chiếu đến  MaSP (SanPham)</p>|
|7|CuaHang|<p>Khóa chính **MaSP, NSX, HSD** </p><p>Khóa ngoại **MaSP, NSX, HSD** tham chiếu đến  MaSP, NSX, HSD (Kho)</p>|
|8|KhachHang|Khóa chính **Sdt**|
|9|NgayLe|Khóa chính **MaNL**|
|10|HoaDon|<p>Khóa chính **MaHD**</p><p>Khóa ngoại **MaNV**, **MaKH** tham chiếu đến MaNV(NhanVien), MaKH(KhachHang)</p>|
|11|ChiTietHoaDon|Khóa chính **MaHD**, **MaSP** tham chiếu đến **MaHD(HoaDon)**, MaSP(SanPham)|
|12|Ca|Khóa chính **MaCa**|
|13|PhanCong|Khóa chính **MaPC**|
|14|ChamCong|Khóa chính **MaPC** tham chiếu đến **MaPC(PhanCong)**|
|15|TinhLuong|<p>Khóa chính **MaNV**, **Ngay**</p><p>Khóa ngoại **MaNV** tham chiếu đến **MaNV (NhanVien)**</p>|
|16|PhuongThucThanhToan|Khóa chính **PTTT**|

<a name="_toc134389927"></a><a name="_toc134397063"></a>**2.4. Cài đặt CSDL và các ràng buộc**

<a name="_toc134389928"></a><a name="_toc134397064"></a>**2.4.1 Tạo bảng và các ràng buộc đơn giản**

***Bảng chức vụ***

|<p>CREATE TABLE dbo.ChucVu</p><p>(</p><p>`	`MaCV INT IDENTITY PRIMARY KEY,</p><p>`	`TenCV NVARCHAR(255) NOT NULL,</p><p>`	`LuongTheoGio FLOAT NOT NULL</p><p>)</p>|
| - |

***Bảng nhân viên***

|<p>CREATE TABLE dbo.NhanVien</p><p>(</p><p>`	`MaNV NVARCHAR(10) PRIMARY KEY,</p><p>`	`TenNV NVARCHAR(255) NOT NULL,</p><p>`	`Sdt NVARCHAR(10) NOT NULL,</p><p>`	`Phai BIT NOT NULL DEFAULT 0, -- Nam 0: | Nữ :1</p><p>`	`NgaySinh DATE NOT NULL,</p><p>`	`Email NVARCHAR(255) NOT NULL ,</p><p>`	`MaCV INT REFERENCES dbo.ChucVu(MaCV) NOT NULL,</p><p>`	`TrangThai BIT NOT NULL DEFAULT 1, -- 1: Còn làm việc | 0: Nghỉ</p><p>`	`TenTK NVARCHAR(255) NOT NULL  UNIQUE,</p><p>`	`MatKhau NVARCHAR(255) NOT NULL,</p><p>`	`Hinh IMAGE NULL</p><p>)</p>|
| - |

***Bảng nhà sản xuất***

|<p>CREATE TABLE dbo.NhaSanXuat</p><p>(</p><p>`	`MaNSX INT IDENTITY PRIMARY KEY,</p><p>`	`TenNSX NVARCHAR(255) NOT NULL,</p><p>`	`DiaChi NVARCHAR(255) NOT NULL</p><p>)</p>|
| - |

***Bảng loại sản phẩm***

|<p>CREATE TABLE dbo.LoaiSanPham</p><p>(</p><p>`	`MaLoai INT IDENTITY PRIMARY KEY,</p><p>`	`TenLoai NVARCHAR(255) NOT NULL</p><p>)</p>|
| - |

***Bảng sản phẩm***

|<p>CREATE TABLE dbo.SanPham</p><p>(</p><p>`	`MaSP INT IDENTITY PRIMARY KEY,</p><p>`	`TenSP NVARCHAR(255) NOT NULL,</p><p>`	`MaNSX INT REFERENCES dbo.NhaSanXuat(MaNSX) ON DELETE SET NULL ON UPDATE CASCADE NULL,</p><p>`	`MaLoai INT REFERENCES dbo.LoaiSanPham(MaLoai) ON DELETE SET NULL ON UPDATE CASCADE NULL,</p><p>`	`GiaBan FLOAT NOT NULL,</p><p>`	`GiaGoc FLOAT NOT NULL,</p><p>`	`TrangThai BIT NOT NULL DEFAULT 0, --1: Còn bán | 0: Hết bán</p><p>`	`Hinh IMAGE NULL</p><p>)</p>|
| - |

***Bảng kho***

|<p>CREATE TABLE dbo.Kho</p><p>(</p><p>`	`MaSP INT REFERENCES dbo.SanPham(MaSP) ON UPDATE CASCADE NOT NULL,</p><p>`	`NSX DATE NOT NULL,</p><p>`	`HSD DATE NOT NULL,</p><p>`	`NgayNhapKho DATE NOT NULL,</p><p>`	`LoaiKho BIT NOT NULL DEFAULT 1, -- 1: Thường | 0: Lạnh</p><p>`	`SLTonKho INT NOT NULL,</p><p>`	`PRIMARY KEY (MaSP, NSX, HSD)</p><p>)</p>|
| - |

***Bảng cửa hàng***

|<p>CREATE TABLE dbo.CuaHang</p><p>(</p><p>`	`MaSP INT NOT NULL,</p><p>`	`NSX DATE NOT NULL,</p><p>`	`HSD DATE NOT NULL,</p><p>`	`NgayXuatKho DATE NOT NULL,</p><p>`	`SoLuong INT NOT NULL,</p><p>`	`FOREIGN KEY (MaSP, NSX, HSD) REFERENCES dbo.Kho(MaSP,NSX, HSD) ON UPDATE CASCADE,</p><p>`	`PRIMARY KEY (MaSP, NSX, HSD)</p><p>)</p>|
| - |

***Bảng khách hàng***

|<p>CREATE TABLE dbo.KhachHang</p><p>(</p><p>`	`Sdt NVARCHAR(10) PRIMARY KEY,</p><p>`	`TenKH NVARCHAR(255) NOT NULL,</p><p>`	`DiemTichLuy FLOAT NOT NULL,</p><p>)</p>|
| - |

***Bảng ngày lễ***

|<p>CREATE TABLE dbo.NgayLe</p><p>(</p><p>`	`MaNL INT IDENTITY PRIMARY KEY,</p><p>`	`Ngay DATE NOT NULL,</p><p>`	`SuKien NVARCHAR(255) NOT NULL</p><p>)</p>|
| - |

***Bảng hóa đơn***

|<p>CREATE TABLE dbo.HoaDon</p><p>(</p><p>`	`MaHD INT IDENTITY PRIMARY KEY,</p><p>`	`MaNV NVARCHAR(10) REFERENCES dbo.NhanVien(MaNV) ON UPDATE CASCADE NULL,</p><p>`	`SdtKH NVARCHAR(10) REFERENCES dbo.KhachHang(Sdt) ON UPDATE CASCADE NULL,</p><p>`	`PTTT INT NULL, -- 1: Tiền mặt | 2: Chuyển Khoản | 3: Thẻ</p><p>`	`Ngay DATE NOT NULL,</p><p>`	`TongTienTT FLOAT NOT NULL DEFAULT 0,</p><p>`	`TongTienLoi FLOAT NOT NULL DEFAULT 0</p><p>)</p>|
| - |

***Bảng chi tiết hóa đơn***

|<p>CREATE TABLE dbo.ChiTietHoaDon</p><p>(</p><p>`	`MaHD INT REFERENCES dbo.HoaDon(MaHD) ON UPDATE CASCADE NOT NULL,</p><p>`	`MaSP INT NOT NULL,</p><p>`	`NSX DATE NOT NULL,</p><p>`	`HSD DATE NOT NULL,</p><p>`	`SoLuong INT NOT NULL,</p><p>`	`GiaBan FLOAT NOT NULL,</p><p>`	`GiaGoc FLOAT NOT NULL,</p><p>`	`ThanhTien FLOAT NOT NULL,</p><p>`	`TienLoi FLOAT NOT NULL,</p><p>`	`FOREIGN KEY (MaSP, NSX, HSD) REFERENCES dbo.CuaHang(MaSP, NSX, HSD)ON UPDATE CASCADE,</p><p>`	`PRIMARY KEY (MaHD, MaSP, NSX, HSD)</p><p>)</p>|
| - |

***Bảng ca***

|<p>CREATE TABLE dbo.Ca</p><p>(</p><p>`	`MaCa NVARCHAR(10) PRIMARY KEY,</p><p>`	`LoaiCa INT NOT NULL,</p><p>`	`GioBatDau TIME NOT NULL,</p><p>`	`GioKetThuc TIME NOT NULL</p><p>)</p>|
| - |

***Bảng phân công***

|<p>CREATE TABLE dbo.PhanCong</p><p>(</p><p>`	`MaPC INT IDENTITY PRIMARY KEY,</p><p>`	`MaNV NVARCHAR(10) REFERENCES dbo.NhanVien(MaNV) ON UPDATE CASCADE NOT NULL,</p><p>`	`MaCa NVARCHAR(10) REFERENCES dbo.Ca(MaCa) ON DELETE CASCADE ON UPDATE CASCADE NOT NULL,</p><p>`	`NgayDangKy DATE NOT NULL,</p><p>)</p>|
| - |

***Bảng chấm công***

|<p>CREATE TABLE dbo.ChamCong</p><p>(</p><p>`	`MaPC INT REFERENCES dbo.PhanCong(MaPC) PRIMARY KEY,</p><p>`	`GioBD TIME NOT NULL,</p><p>`	`GioKT TIME NOT NULL,</p><p>`	`Luong FLOAT NULL,</p><p>)</p>|
| - |

***Bảng tính lương***

|<p>CREATE TABLE dbo.TinhLuong</p><p>(</p><p>`	`MaNV NVARCHAR(10) REFERENCES dbo.NhanVien(MaNV) NOT NULL,</p><p>`	`Ngay DATE NOT NULL,</p><p>`	`TongLuong FLOAT NOT NULL,</p><p>`	`PRIMARY KEY (MaNV, Ngay)</p><p>)</p>|
| - |

***Bảng phương thức thanh toán***

|<p>CREATE TABLE PhuongThucThanhToan</p><p>(</p><p>`	`PTTT INT PRIMARY KEY,</p><p>`	`TenPTTT NVARCHAR(255)</p><p>)</p>|
| :- |

<a name="_toc134389929"></a><a name="_toc134397065"></a>**2.4.2 Trigger kiểm tra các ràng buộc**

***Trigger kiểm tra nhân viên***

|<p>CREATE TRIGGER tg\_CheckNhanVien ON dbo.NhanVien</p><p>AFTER INSERT, UPDATE AS </p><p>DECLARE @sdt NVARCHAR(10), @ngaysinh DATE, @email NVARCHAR(255), @tentk NVARCHAR(255), @matkhau NVARCHAR(255)</p><p>SELECT @sdt=n.Sdt,@ngaysinh=n.NgaySinh,@email=n.Email,@tentk=n.TenTK,@matkhau=n.MatKhau</p><p>FROM inserted n</p><p>BEGIN</p><p>`	`DECLARE @error INT</p><p>`	`SET @error = 0</p><p>`	`--check SO DIEN THOAI</p><p>`	`IF @sdt NOT LIKE '[0][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ ', 16, 1)</p><p>`		`SET @error = 1</p><p>`	`END</p><p>`	`--check NGAY SINH</p><p>`	`IF DATEDIFF(year, @ngaysinh, GETDATE()) < 18</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'NGÀY SINH DƯỚI 18 TUỔI ', 16, 1)</p><p>`		`SET @error = 1</p><p>`	`END</p><p>`	`--check EMAIL</p><p>`	`IF @email NOT LIKE '%\_@\_\_%.\_\_%'</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'EMAIL KHÔNG HỢP LỆ ', 16, 1)</p><p>`		`SET @error = 1</p><p>`	`END</p><p>`	`--check TEN TAI KHOAN</p><p>`	`IF LEN(@tentk) < 5 OR @tentk LIKE '% %'</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'TÊN TÀI KHOẢN KHÔNG HỢP LỆ', 16, 1)</p><p>`		`SET @error = 1</p><p>`	`END</p><p>`	`--check MAT KHAU</p><p>`	`IF LEN(@matkhau) < 5</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'MẬT KHẨU KHÔNG HỢP LỆ ', 16, 1)</p><p>`		`SET @error = 1</p><p>`	`END</p><p>`	`-- ROLLBACK</p><p>`	`IF @error = 1</p><p>`	`BEGIN</p><p>`		`RAISERROR(N'VUI LÒNG NHẬP LẠI !', 16, 1)</p><p>`		`ROLLBACK TRANSACTION</p><p>`	`END</p><p>END</p>|
| - |

***Trigger tích điểm***

|<p>CREATE TRIGGER TichDiem  ON dbo.HoaDon</p><p>AFTER UPDATE </p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @diemtichluy FLOAT, @sdt nvarchar (10)</p><p>`	`SELECT @diemtichluy = i.TongTienTT \* 2 / 100, @sdt = KhachHang.Sdt</p><p>`	`FROM Inserted AS i INNER JOIN dbo.KhachHang ON KhachHang.Sdt = i.SdtKH </p><p>`	`UPDATE dbo.KhachHang SET DiemTichLuy = @diemtichluy  WHERE Sdt = @sdt</p><p>END</p>|
| - |

<a name="_toc134389930"></a><a name="_toc134397066"></a>**2.4.3 Các view**

***View các sản phẩm trong kho***

|<p>CREATE VIEW ViewKho </p><p>AS</p><p>SELECT Kho.MaSP, TenSP, NSX, HSD, NgayNhapKho, LoaiKho, SLTonKho </p><p>FROM dbo.Kho INNER JOIN dbo.SanPham ON SanPham.MaSP = Kho.MaSP</p>|
| :- |

***View các sản phẩm trong cửa hàng***

|<p>CREATE VIEW ViewCuaHang </p><p>AS</p><p>SELECT dbo.CuaHang.MaSP, TenSP, NSX, HSD, NgayXuatKho, SoLuong</p><p>FROM dbo.CuaHang INNER JOIN dbo.SanPham ON SanPham.MaSP = dbo.CuaHang.MaSP</p><p>GO</p>|
| - |

***View các sản phẩm trong hóa đơn thanh toán*** 

|<p>CREATE VIEW ChiTietHoaDonThanhToan</p><p>AS</p><p>SELECT MaHD, TenSP, SoLuong, ChiTietHoaDon.GiaBan, ThanhTien</p><p>FROM dbo.ChiTietHoaDon INNER JOIN dbo.SanPham ON SanPham.MaSP = ChiTietHoaDon.MaSP</p><p>WHERE MaHD = dbo.MaxHD()</p>|
| :- |

***View xem bảng phân công của nhân viên***

|<p>CREATE VIEW XemBangPC\_NhanVien</p><p>AS</p><p>SELECT MaPC, PhanCong.MaNV, TenNV, Ca.MaCa, GioBatDau, GioKetThuc, NgayDangKy</p><p>FROM dbo.NhanVien, dbo.PhanCong, dbo.Ca </p><p>WHERE dbo.NhanVien.MaNV = dbo.PhanCong.MaNV AND dbo.PhanCong.MaCa = dbo.Ca.MaCa</p><p></p>|
| :- |


**

<a name="_toc134389931"></a><a name="_toc134397067"></a>**CHƯƠNG 3: THIẾT KẾ CÁC CHỨC NĂNG**

<a name="_toc134389932"></a><a name="_toc134397068"></a>**3.1 Kết nối cơ sở dữ liệu**

|<p>internal class DBConnection</p><p>`    `{</p><p>`        `SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);</p><p></p><p>`        `public DataTable LayDanhSach(string sqlStr)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);</p><p>`                `DataTable data = new DataTable();</p><p>`                `adapter.Fill(data);</p><p>`                `return data;</p><p>`            `}</p><p>`            `catch (Exception ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Lấy danh sách thất bại\n" + ex, "Thông báo");</p><p>`            `}</p><p>`            `finally</p><p>`            `{</p><p>`                `conn.Close();</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p><p></p><p>`        `public void Execute(string query)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `SqlCommand cmd = new SqlCommand(query, conn);</p><p></p><p>`                `if (cmd.ExecuteNonQuery() > 0)</p><p>`                    `MessageBox.Show("Thao tác thành công", "Thông báo");</p><p>`                `else MessageBox.Show("Thao tác thất bại", "Thông báo");</p><p>`            `}</p><p>`            `catch (Exception ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Thất bại\n" + ex, "Thông báo");</p><p>`            `}</p><p>`            `finally</p><p>`            `{</p><p>`                `conn.Close();</p><p>`            `}</p><p>`        `}</p><p></p><p>`        `public DataTable TimKiem(string sqlStr)</p><p>`        `{</p><p>`            `SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);</p><p>`            `DataTable data = new DataTable();</p><p>`            `adapter.Fill(data);</p><p>`            `return data;</p><p>`        `}</p><p>`    `}</p>|
| - |

<a name="_toc134389933"></a><a name="_toc134397069"></a>**3.2 Các thủ tục, hàm**

<a name="_toc134389934"></a><a name="_toc134397070"></a>**3.2.1 Thông tin nhân viên**

**a. Hàm**

Đặt mã nhân viên

|<p>CREATE FUNCTION DatMaNV()</p><p>RETURNS NVARCHAR(10)</p><p>AS </p><p>BEGIN</p><p>`	`DECLARE @manv NVARCHAR(10)</p><p>`	`DECLARE @so NVARCHAR(10)</p><p></p><p>`	`IF NOT EXISTS (SELECT \* FROM dbo.NhanVien)</p><p>`	`BEGIN</p><p>`		`SET @so = '0';</p><p>`    `END</p><p>`	`ELSE</p><p>`	`BEGIN</p><p>`		`SELECT @so = MAX(MaNV) FROM dbo.NhanVien;</p><p>`		`SET @so = RIGHT(@so, 5);</p><p>`		`SET @So = CAST ((CAST(@so AS INT) +1) AS NVARCHAR(10))</p><p>`	`END</p><p>`	`SET @manv = 'NV' + RIGHT('00000' + @so, 5)</p><p>`	`RETURN @manv;</p><p>END</p>|
| - |

`		`**b. Thủ tục**

Thêm nhân viên

|<p>CREATE PROCEDURE sp\_ThemNhanVien</p><p>`	`@tennv NVARCHAR(255),</p><p>`	`@sdt NVARCHAR(10),</p><p>`	`@phai BIT,</p><p>`	`@ngaysinh DATE,</p><p>`	`@email NVARCHAR(255),</p><p>`	`@macv INT,</p><p>`	`@trangthai BIT,</p><p>`	`@tentk NVARCHAR(255),</p><p>`	`@matkhau NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`	`IF EXISTS (SELECT \* FROM dbo.NhanVien WHERE TenTK = @tentk)</p><p>`		`RAISERROR(N'LỖI TRÙNG TÊN TÀI KHOẢN', 16, 1)</p><p>`	`ELSE</p><p>`	`BEGIN</p><p>`		`DECLARE @newmanv NVARCHAR(10)</p><p>`		`SET @newmanv = dbo.DatMaNV()</p><p>`		`INSERT INTO dbo.NhanVien</p><p>`		`(MaNV, TenNV,Sdt,Phai,NgaySinh,Email,MaCV,TrangThai,TenTK,MatKhau)</p><p>`		`VALUES</p><p>`		`(@newmanv, @tennv, @sdt, @phai, @ngaysinh, @email, @macv, @trangthai, @tentk, @matkhau)</p><p>		</p><p>`		`IF EXISTS (SELECT name FROM sys.sql\_logins WHERE name = @tentk)</p><p>`		`BEGIN</p><p>`			`DECLARE @sqltemp55 nvarchar(2000)</p><p>`			`SET @sqltemp55= 'DROP LOGIN ' + @tentk</p><p>`			`EXEC (@sqltemp55)</p><p>`		`END</p><p></p><p>`		`DECLARE @sqlString34 nvarchar(2000)</p><p>`		`SET @sqlString34= 'CREATE LOGIN [' + @tentk +'] WITH PASSWORD ='''+ @matkhau +''',DEFAULT\_DATABASE=[QuanLyCuaHangTienLoi], CHECK\_EXPIRATION=OFF, CHECK\_POLICY=OFF'</p><p>`		`EXEC (@sqlString34)</p><p></p><p>`		`--Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)</p><p>`		`DECLARE @sqltemp3 nvarchar(2000)</p><p>`		`SET @sqltemp3= 'CREATE USER ' + @tentk +' FOR LOGIN '+ @tentk</p><p>`		`EXEC (@sqltemp3)</p><p></p><p>`		`IF @macv <> 1</p><p>`			`BEGIN</p><p>`				`DECLARE @sqltemp1 nvarchar(2000)</p><p>`				`SET @sqltemp1= 'ALTER ROLE RoleNhanVien ADD MEMBER ' + @tentk</p><p>`				`EXEC (@sqltemp1)</p><p>`			`--ALTER ROLE RoleNhanVien ADD MEMBER @tentk</p><p>`			`END</p><p>`		`ELSE</p><p>`			`BEGIN</p><p>`				`DECLARE @sqltemp2 nvarchar(2000)</p><p>`				`SET @sqltemp2= 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @tentk</p><p>`				`EXEC (@sqltemp2)</p><p>`				`--ALTER ROLE RoleQuanLy ADD MEMBER @tentk</p><p>`			`END</p><p>`	`END</p><p>END</p>|
| - |

Sửa nhân viên

|<p>CREATE PROCEDURE sp\_SuaNhanVien</p><p>`	`@manv NVARCHAR(10),</p><p>`	`@tennv NVARCHAR(255),</p><p>`	`@sdt NVARCHAR(10),</p><p>`	`@phai BIT,</p><p>`	`@ngaysinh DATE,</p><p>`	`@email NVARCHAR(255),</p><p>`	`@macv INT,</p><p>`	`@trangthai BIT,</p><p>`	`@tentk NVARCHAR(255),</p><p>`	`@matkhau NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @tentkcu NVARCHAR(255)</p><p>`	`SELECT @tentkcu = TenTK FROM dbo.NhanVien WHERE MaNV = @manv</p><p></p><p>`	`DECLARE @sqltemp99 nvarchar(2000)</p><p>`	`SET @sqltemp99= 'Drop user ' + @tentkcu;</p><p>`	`EXEC (@sqltemp99)</p><p>`	`DECLARE @sqltemp100 nvarchar(2000)</p><p>`	`SET @sqltemp100= 'Drop login ' + @tentkcu;</p><p>`	`EXEC (@sqltemp100)</p><p></p><p>`	`IF EXISTS (SELECT \* FROM dbo.NhanVien WHERE TenTK = @tentk AND TenTK <> @tentkcu)</p><p>`		`RAISERROR(N'LỖI TRÙNG TÊN TÀI KHOẢN', 16, 1)</p><p>`	`ELSE</p><p>`	`BEGIN</p><p>`		`UPDATE dbo.NhanVien SET TenNV = @tennv,</p><p>`				`Sdt = @sdt,</p><p>`				`Phai = @phai,</p><p>`				`NgaySinh = @ngaysinh,</p><p>`				`Email = @email,</p><p>`				`MaCV = @macv,</p><p>`				`TenTK = @tentk,</p><p>`				`MatKhau = @matkhau,</p><p>`				`TrangThai = @trangthai</p><p>`		`WHERE MaNV = @manv</p><p>		</p><p>`		`IF EXISTS (SELECT name FROM sys.sql\_logins WHERE name = @tentk)</p><p>`		`BEGIN</p><p>`			`DECLARE @sqltemp55 nvarchar(2000)</p><p>`			`SET @sqltemp55= 'DROP LOGIN ' + @tentk</p><p>`			`EXEC (@sqltemp55)</p><p>`		`END</p><p></p><p>`		`DECLARE @sqlString34 nvarchar(2000)</p><p>`		`SET @sqlString34= 'CREATE LOGIN [' + @tentk +'] WITH PASSWORD ='''+ @matkhau  +''', DEFAULT\_DATABASE=[QuanLyCuaHangTienLoi], CHECK\_EXPIRATION=OFF, CHECK\_POLICY=OFF'</p><p>`		`EXEC (@sqlString34)</p><p></p><p>`		`--Tạo tài khoản người dùng đối với nhân viên đó trên database (tên người dùng trùng với tên login)</p><p>`		`DECLARE @sqltemp3 nvarchar(2000)</p><p>`		`SET @sqltemp3= 'CREATE USER ' + @tentk +' FOR LOGIN '+ @tentk</p><p>`		`EXEC (@sqltemp3)</p><p></p><p>`		`IF @macv <> 1</p><p>`			`BEGIN</p><p>`				`DECLARE @sqltemp1 nvarchar(2000)</p><p>`				`SET @sqltemp1= 'ALTER ROLE RoleNhanVien ADD MEMBER ' + @tentk</p><p>`				`EXEC (@sqltemp1)</p><p>`			`--ALTER ROLE RoleNhanVien ADD MEMBER @tentk</p><p>`			`END</p><p>`		`ELSE</p><p>`			`BEGIN</p><p>`				`DECLARE @sqltemp2 nvarchar(2000)</p><p>`				`SET @sqltemp2= 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @tentk</p><p>`				`EXEC (@sqltemp2)</p><p>`				`--ALTER ROLE RoleQuanLy ADD MEMBER @tentk</p><p>`			`END</p><p>`	`END</p><p>END</p>|
| - |

Xóa nhân viên

|<p>CREATE PROCEDURE sp\_XoaNhanVien </p><p>`	`@manv NVARCHAR(10)</p><p>AS</p><p>BEGIN</p><p>`	`IF EXISTS (SELECT \* FROM dbo.PhanCong WHERE MaNV = @maNV)</p><p>`		`BEGIN</p><p>`			`UPDATE NhanVien SET TrangThai = 0 WHERE MaNV = @maNV;</p><p>`		`END</p><p>`	`ELSE</p><p>`		`BEGIN</p><p>`			`DECLARE @tentk NVARCHAR(255)</p><p>`			`SELECT @tentk = TenTK FROM dbo.NhanVien WHERE MaNV = @manv</p><p></p><p>`			`DECLARE @sqltemp99 nvarchar(2000)</p><p>`			`SET @sqltemp99= 'Drop user ' + @tentk;</p><p>`			`EXEC (@sqltemp99)</p><p>`			`DECLARE @sqltemp100 nvarchar(2000)</p><p>`			`SET @sqltemp100= 'Drop login ' + @tentk;</p><p>`			`EXEC (@sqltemp100)</p><p></p><p>`			`DELETE FROM dbo.NhanVien WHERE MaNV = @manv</p><p>`		`END</p><p>END</p>|
| - |

<a name="_toc134389935"></a><a name="_toc134397071"></a>**3.2.2 Thông tin nhà sản xuất**

Thủ tục thêm nhà sản xuất

|<p>CREATE PROC sp\_ThemNSX</p><p>@tennsx NVARCHAR(255), @diachi NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.NhaSanXuat</p><p>`	`(</p><p>`	    `TenNSX,</p><p>`	    `DiaChi</p><p>`	`)</p><p>`	`VALUES</p><p>`	`(   @tennsx,</p><p>`	    `@diachi</p><p>`	`)</p><p>END</p>|
| - |

Thủ tục sửa nhà sản xuất

|<p>CREATE PROC sp\_SuaNSX</p><p>@mansx INT, @tennsx NVARCHAR(255), @diachi NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`    `UPDATE dbo.NhaSanXuat SET TenNSX = @tennsx, DiaChi= @diachi WHERE MaNSX = @mansx</p><p>END</p>|
| - |

Thủ tục xóa nhà sản xuất 

|<p>CREATE PROC sp\_XoaNSX</p><p>@mansx INT</p><p>AS</p><p>BEGIN</p><p>`    `DELETE FROM dbo.NhaSanXuat WHERE MaNSX = @mansx</p><p>END</p>|
| - |

<a name="_toc134389937"></a><a name="_toc134397072"></a>**3.2.3 Sản phẩm**

Thủ tục hêm sản phẩm

|<p>CREATE PROCEDURE sp\_ThemSanPham</p><p>`	`@tensp NVARCHAR(255),</p><p>`	`@mansx INT,</p><p>`	`@maloai INT,</p><p>`	`@giaban FLOAT,</p><p>`	`@giagoc FLOAT,</p><p>`	`@trangthai BIT</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.SanPham</p><p>`	 `(TenSP,MaNSX,MaLoai,GiaBan,GiaGoc,TrangThai</p><p>`	`)</p><p>`	`VALUES</p><p>`	`(@tensp, @mansx, @maloai, @giaban, @giagoc, @trangthai)</p><p>END</p>|
| :- |

Thủ tục sửa sản phẩm

|<p>CREATE PROCEDURE sp\_SuaSanPham</p><p>`	`@masp INT,</p><p>`	`@tensp NVARCHAR(255),</p><p>`	`@mansx INT,</p><p>`	`@maloai INT,</p><p>`	`@giaban FLOAT,</p><p>`	`@giagoc FLOAT,</p><p>`	`@trangthai BIT</p><p>AS</p><p>BEGIN</p><p>`	`UPDATE dbo.SanPham SET 	</p><p>`				`TenSP = @tensp,</p><p>`				`MaNSX = @mansx,</p><p>`				`MaLoai = @maloai,</p><p>`				`GiaBan = @giaban,</p><p>`				`GiaGoc = @giagoc,</p><p>`				`TrangThai = @trangthai</p><p>`	`WHERE MaSP = @masp</p><p>END</p>|
| :- |

Thủ tục xóa sản phẩm

|<p>CREATE PROCEDURE sp\_XoaSanPham</p><p>`	`@masp INT</p><p>AS</p><p>BEGIN</p><p>`	`IF EXISTS (SELECT \* FROM dbo.Kho WHERE MaSP = @masp)</p><p>`		`RAISERROR ('Bạn đã xóa sản phẩm đang có ở Kho. Không xóa được!', 16, 1)</p><p>`	`ELSE	</p><p>`	`DELETE FROM dbo.SanPham WHERE MaSP = @masp</p><p>END</p>|
| :- |

<a name="_toc134389938"></a><a name="_toc134397073"></a>**3.2.4 Kho**

Thủ tục nhập kho

|<p>CREATE PROCEDURE sp\_NhapKho</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE,</p><p>`	`@ngaynhapkho DATE,</p><p>`	`@loaikho BIT, </p><p>`	`@sltonkho INT</p><p>AS</p><p>BEGIN</p><p>`	`IF EXISTS (SELECT \* FROM dbo.Kho WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd)</p><p>`		`UPDATE dbo.Kho SET SLTonKho += @sltonkho </p><p>`		`WHERE MaSP = @masp  AND NSX = @nsx AND HSD = @hsd</p><p>`	`ELSE</p><p>`		`INSERT INTO dbo.Kho (MaSP, NSX, HSD, NgayNhapKho,LoaiKho,SLTonKho)</p><p>`		`VALUES (@masp, @nsx, @hsd, @ngaynhapkho, @loaikho, @sltonkho)</p><p>END</p>|
| :- |

Thủ tục xóa sản phẩm vào kho

|<p>CREATE PROCEDURE sp\_XoaSpVaoKho</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE</p><p>AS</p><p>BEGIN</p><p>`	`DELETE FROM dbo.Kho WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>END</p>|
| :- |

Thủ tục sửa sản phẩm vào kho

|<p>CREATE PROCEDURE sp\_SuaSpVaoKho</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE,</p><p>`	`@ngaynhapkho DATE,</p><p>`	`@loaikho BIT, </p><p>`	`@sltonkho INT</p><p>AS</p><p>BEGIN</p><p>`	`UPDATE dbo.Kho SET	</p><p>`			`NgayNhapKho = @ngaynhapkho,</p><p>`			`LoaiKho = @loaikho, </p><p>`			`SLTonKho = @sltonkho</p><p>`	`WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>END</p>|
| :- |

<a name="_toc134389939"></a><a name="_toc134397074"></a>**3.2.5 Cửa hàng**

Thủ tục xuất kho

|<p>CREATE PROCEDURE sp\_XuatKho</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE,</p><p>`	`@ngayxuatkho DATE,</p><p>`	`@soluong INT</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @sltk INT</p><p>`	`SELECT @sltk = SLTonKho FROM Kho WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`	`IF (@sltk >= @soluong)</p><p>`		`BEGIN</p><p>`			`UPDATE Kho SET SLTonKho -= @soluong</p><p>`			`WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`				`IF EXISTS (SELECT \* FROM dbo.CuaHang WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd)</p><p>`					`UPDATE dbo.CuaHang SET SoLuong += @soluong </p><p>`					`WHERE MaSP = @masp  AND NSX = @nsx AND HSD = @hsd</p><p>`				`ELSE</p><p>`					`INSERT INTO dbo.CuaHang(MaSP, NSX, HSD, NgayXuatKho, SoLuong)</p><p>`					`VALUES (@masp, @nsx, @hsd, @ngayxuatkho, @soluong)</p><p>`		`END</p><p>`	`ELSE</p><p>`		`RAISERROR('Số lượng trong Kho không đủ để thêm Sản Phẩm vào Cửa Hàng', 16,1)</p><p>END	</p><p></p>|
| :- |
Thủ tục trả kho

|<p>CREATE PROCEDURE sp\_TraKho</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE,</p><p>`	`@ngayxuatkho DATE,</p><p>`	`@soluong INT</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @sltrakho INT</p><p>`	`SELECT @sltrakho = SoLuong FROM dbo.CuaHang WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`	`IF (@sltrakho >= @soluong)</p><p>`		`BEGIN</p><p>`			`UPDATE dbo.CuaHang SET SoLuong -= @soluong WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`			`UPDATE dbo.Kho SET	  SLTonKho += @soluong WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`		`END</p><p>`	`ELSE</p><p>`		`RAISERROR('Số lượng Trả Kho lớn hơn số lượng hiện còn có trong Cửa Hàng', 16,1)</p><p>END</p>|
| :- |

<a name="_toc134389940"></a><a name="_toc134397075"></a>**3.2.6 Khách Hàng**

Thủ tục thêm khách hàng

|<p>CREATE PROCEDURE sp\_ThemKhachHang</p><p>`	`@sdt NVARCHAR(10),</p><p>`	`@tenkh NVARCHAR(255),</p><p>`	`@diemtichluy FLOAT</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.KhachHang</p><p>`	`(Sdt,TenKH,DiemTichLuy)</p><p>`	`VALUES</p><p>`	`(@sdt,@tenkh, @diemtichluy)</p><p>END</p>|
| :- |

Thủ tục sửa khách hàng

|<p>CREATE PROCEDURE sp\_SuaKhachHang</p><p>`	`@sdt NVARCHAR(10),</p><p>`	`@tenkh NVARCHAR(255),</p><p>`	`@diemtichluy INT</p><p>AS</p><p>BEGIN</p><p>`	`UPDATE dbo.KhachHang SET </p><p>`				`TenKH = @tenkh,</p><p>`				`DiemTichLuy = @diemtichluy			   </p><p>`	`WHERE SDT = @sdt</p><p>END</p>|
| :- |

Thủ tục xóa khách hàng

|<p>CREATE PROCEDURE sp\_XoaKhachHang</p><p>`	`@sdt NVARCHAR(10)</p><p>AS</p><p>BEGIN</p><p>`	`DELETE FROM dbo.KhachHang WHERE sdt = @sdt</p><p>END</p>|
| :- |

<a name="_toc134389941"></a><a name="_toc134397076"></a>**3.2.7 Ngày lễ**

Thủ tục thêm ngày lễ

|<p>CREATE PROC sp\_ThemNgayLe</p><p>@ngay DATE, @sukien NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.NgayLe</p><p>`	`(</p><p>`		`Ngay,</p><p>`		`SuKien</p><p>`	`)</p><p>`	`VALUES</p><p>`	`(   @ngay,</p><p>`		`@sukien</p><p>`	`)</p><p>END</p>|
| - |

Thủ tục sửa ngày lễ

|<p>CREATE PROC sp\_SuaNgayLe</p><p>@manl INT, @ngay DATE, @sukien NVARCHAR(255)</p><p>AS</p><p>BEGIN</p><p>`    `UPDATE dbo.NgayLe SET Ngay = @ngay, SuKien = @sukien WHERE MaNL = @manl</p><p>END</p>|
| - |

Thủ tục xóa ngày lễ

|<p>CREATE PROC sp\_XoaNgayLe</p><p>@manl INT</p><p>AS</p><p>BEGIN</p><p>`    `DELETE FROM dbo.NgayLe WHERE MaNL = @manl</p><p>END</p>|
| - |

<a name="_toc134389942"></a><a name="_toc134397077"></a>**3.2.8 Hóa đơn**

Thủ tục thêm hóa đơn

|<p>CREATE PROCEDURE sp\_ThemHoaDon</p><p>`	`@manv NVARCHAR(10),</p><p>`	`@sdtkh NVARCHAR(10),</p><p>`	`@pttt INT</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.HoaDon(MaNV,sdtkh,PTTT,Ngay,TongTienTT, TongTienLoi)</p><p>`	`VALUES (@manv,  @sdtkh,   @pttt,  GETDATE(), 0.0, 0.0)</p><p>END</p>|
| :- |

Thủ tục xóa hóa đơn

|<p>CREATE PROCEDURE sp\_XoaHoaDon</p><p>@mahd INT</p><p>AS</p><p>BEGIN</p><p>`	`DELETE FROM dbo.ChiTietHoaDon WHERE MaHD = @mahd</p><p>`	`DELETE FROM dbo.HoaDon WHERE MaHD = @mahd</p><p>END</p>|
| :- |

<a name="_toc134389943"></a><a name="_toc134397078"></a>**3.2.9 Thông tin chi tiết hóa đơn**

Thủ tục thêm chi tiết hóa đơn

|<p>CREATE PROCEDURE sp\_ThemChiTietHoaDon</p><p>`	`@mahd INT,</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE,</p><p>`	`@sl INT</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE</p><p>`	`@giaban FLOAT,</p><p>`	`@giagoc FLOAT,</p><p>`	`@thanhtien FLOAT,</p><p>`	`@tienloi FLOAT</p><p></p><p>`	`SET @giaban = 0</p><p>`	`SET @giagoc = 0</p><p>`	`SET @thanhtien = 0</p><p>`	`SET @tienloi = 0</p><p>`	`DECLARE @MaHDMoi INT</p><p>`	`SET @MaHDMoi = @mahd</p><p></p><p>`	`DECLARE @slch INT</p><p>`	`SELECT @slch = SoLuong FROM CuaHang WHERE MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`	`IF (@slch >= @sl )</p><p>`	`BEGIN</p><p>`		`IF NOT EXISTS (SELECT \* FROM dbo.HoaDon WHERE MaHD = @mahd)</p><p>`		`BEGIN</p><p>`			`EXEC dbo.sp\_ThemHoaDon	@manv = NULL, -- nvarchar(10)</p><p>`							`@sdtkh = NULL, -- nvarchar(10)</p><p>`							`@pttt = NULL  -- nvarchar(255)</p><p>`			`SELECT @MaHDMoi = MAX(MaHD) FROM dbo.HoaDon </p><p>`		`END;</p><p></p><p>`		`SELECT @giaban = GiaBan, @giagoc = GiaGoc FROM dbo.SanPham WHERE @masp = MaSP </p><p>`		`IF EXISTS (SELECT MaHD, MaSP, NSX, HSD FROM dbo.ChiTietHoaDon WHERE MaHD = @MaHDMoi AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd)</p><p>`			`BEGIN</p><p>				</p><p>`				`UPDATE dbo.ChiTietHoaDon SET SoLuong += @sl WHERE MaHD = @MaHDMoi AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`				`UPDATE dbo.ChiTietHoaDon SET ThanhTien = SoLuong \* GiaBan WHERE MaHD = @MaHDMoi AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`				`UPDATE dbo.ChiTietHoaDon SET TienLoi = ThanhTien - (GiaGoc \* SoLuong) WHERE MaHD = @MaHDMoi AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`				`SELECT @thanhtien = ThanhTien, @tienloi = TienLoi  FROM dbo.ChiTietHoaDon WHERE MaHD = @MaHDMoi AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>`			`END;</p><p>`		`ELSE</p><p>`			`BEGIN</p><p>`				`SET @thanhtien = @sl \* @giaban</p><p>`				`SET @tienloi = @thanhtien - (@giagoc \* @sl)</p><p></p><p>`				`INSERT INTO dbo.ChiTietHoaDon (MaHD,MaSP, NSX, HSD ,SoLuong,GiaBan,GiaGoc,ThanhTien,TienLoi)</p><p>`				`VALUES (@MaHDMoi, @masp, @nsx, @hsd, @sl, @giaban, @giagoc, @thanhtien, @tienloi)</p><p>`			`END;</p><p>`		`UPDATE dbo.HoaDon SET TongTienTT += @thanhtien WHERE MaHD = @MaHDMoi </p><p>`		`UPDATE dbo.HoaDon SET TongTienLoi += @tienloi WHERE MaHD = @MaHDMoi</p><p>`	`END</p><p>`	`ELSE</p><p>`	`BEGIN</p><p>`		`RAISERROR('Sản Phẩm không còn đủ trong Cửa Hàng để Khách Hàng mua!', 16, 1)</p><p>`	`END</p><p>END</p>|
| :- |

Thủ tục xóa chi tiết hóa đơn

|<p>CREATE PROCEDURE sp\_XoaChiTietHoaDon</p><p>`	`@mahd INT,</p><p>`	`@masp INT,</p><p>`	`@nsx DATE,</p><p>`	`@hsd DATE</p><p>AS</p><p>BEGIN</p><p>`	`DELETE FROM dbo.ChiTietHoaDon WHERE MaHD = @mahd AND MaSP = @masp AND NSX = @nsx AND HSD = @hsd</p><p>END</p>|
| :- |

<a name="_toc134389945"></a><a name="_toc134397079"></a>**3.2.10 Thông tin phân công**

Thủ tục thêm phân công

|<p>CREATE PROCEDURE sp\_ThemPhanCong</p><p>`	`@manv NVARCHAR(10),</p><p>`	`@maca NVARCHAR(10),</p><p>`	`@ngaydangky DATE</p><p>AS</p><p>BEGIN</p><p>`	`INSERT INTO dbo.PhanCong</p><p>`	`(MaNV,MaCa,NgayDangKy)</p><p>`	`VALUES</p><p>`	`( @manv, @maca, @ngaydangky)</p><p></p><p>`	`DECLARE @maxmapc int</p><p>`	`SELECT @maxmapc = MAX(MaPC) FROM dbo.PhanCong</p><p>`	`INSERT dbo.ChamCong</p><p>`	`(MaPC, GioBD,GioKT,Luong)</p><p>`	`VALUES(@maxmapc, NULL, NULL, NULL)</p><p>END</p><p>GO</p>|
| - |

Thủ tục xóa phân công

|<p>CREATE PROCEDURE sp\_XoaPhanCong</p><p>`	`@mapc INT</p><p>AS</p><p>BEGIN</p><p>`	`DELETE FROM dbo.ChamCong WHERE MaPC = @mapc</p><p>`	`DELETE FROM PhanCong Where MaPC = @mapc</p><p>END</p>|
| :- |

<a name="_toc134389947"></a><a name="_toc134397080"></a>**3.2.11 Hàm tính doanh thu**

|<p>CREATE FUNCTION TinhDoanhThu()</p><p>RETURNS NVARCHAR(255)</p><p>as</p><p>BEGIN</p><p>`   `DECLARE @result FLOAT</p><p>`   `set @RESULT = 0</p><p>`   `SELECT @result +=TongTienTT FROM dbo.HoaDon</p><p>`   `RETURN FORMAT(@result, 'N')</p><p>END</p>|
| - |

<a name="_toc134389948"></a><a name="_toc134397081"></a>**3.2.12 Hàm lọc doanh thu**

|<p>CREATE FUNCTION LocDoanhThu(</p><p>@ngaybatdau DATE,</p><p>@ngayketthuc DATE)</p><p>RETURNS TABLE</p><p>AS</p><p>RETURN</p><p>(</p><p>`	`SELECT \* FROM dbo.HoaDon WHERE @ngaybatdau <= Ngay AND Ngay <= @ngayketthuc</p><p>)</p>|
| - |

<a name="_toc134389949"></a><a name="_toc134397082"></a>**3.2.13 Thủ tục Update lại cửa hàng khi thanh toán**

|<p>CREATE PROCEDURE UpdateLaiCuaHangKhiThanhToan</p><p>AS</p><p>BEGIN</p><p>	</p><p>`	`DECLARE @bangthanhtoan TABLE (masptt INT, nsxtt DATE, hsdtt DATE, sl int)</p><p>`	`INSERT INTO @bangthanhtoan (masptt, nsxtt, hsdtt, sl)</p><p>`	`SELECT MaSP, NSX, HSD, SoLuong</p><p>`	`FROM dbo.BangChiTietHoaDonThanhToan()</p><p>`	`SELECT \* FROM @bangthanhtoan</p><p>`	`DECLARE @counter INT = 1</p><p>`	`WHILE @counter <= (SELECT COUNT(\*) FROM @bangthanhtoan)</p><p>`	`BEGIN</p><p>`		`DECLARE @masptt INT, @nsxtt DATE, @hsdtt DATE, @sl INT</p><p>`		`SELECT TOP 1 @masptt =masptt, @nsxtt = nsxtt, @hsdtt = hsdtt, @sl = sl FROM @bangthanhtoan ORDER BY masptt, nsxtt, hsdtt</p><p>`		`DELETE FROM @bangthanhtoan WHERE @masptt =masptt AND @nsxtt = nsxtt AND @hsdtt = hsdtt</p><p>`		`-- Thực hiện các hành động khác trên bản ghi này</p><p>`		`UPDATE CuaHang SET SoLuong -= @sl</p><p>`		`WHERE MaSP = @masptt AND NSX = @nsxtt AND HSD = @hsdtt</p><p>`		`-- Tăng biến đếm để xử lý bản ghi tiếp theo</p><p>`	`END</p><p>END</p>|
| - |

<a name="_toc134389950"></a><a name="_toc134397083"></a>**3.2.14 Thủ tục UpdateGioBD**

|<p>CREATE PROCEDURE UpDateGioBD</p><p>`	`@mapc INT,</p><p>`	`@giobd TIME</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @giobatdauca TIME, @gioketthucca TIME</p><p>`	`SELECT @giobatdauca = GioBatDau, @gioketthucca = GioBatDau </p><p>FROM dbo.PhanCong INNER JOIN Ca ON Ca.MaCa = PhanCong.MaCa </p><p>`	`WHERE @mapc = MaPC</p><p>`	`SET @giobatdauca = DATEADD(MINUTE, -5, @giobatdauca)</p><p>`	`SET @gioketthucca = DATEADD(MINUTE, 5, @gioketthucca)</p><p>`	`IF @giobatdauca <= @giobd AND @giobd <= @gioketthucca</p><p>`		`UPDATE dbo.ChamCong SET GioBD = @giobd WHERE MaPC = @mapc</p><p>`	`ELSE </p><p>`		`RAISERROR('Bạn đã nhập giờ bắt đầu không nằm trong khoảng thời gian được phân công!', 16, 1)</p><p>END</p>|
| - |

<a name="_toc134389951"></a><a name="_toc134397084"></a>**3.2.15 Thủ tục UpdateGioKT**

|<p>CREATE PROCEDURE UpDateGioKT</p><p>`	`@mapc INT,</p><p>`	`@giokt TIME</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @giobatdauca TIME, @gioketthucca TIME</p><p>`	`SELECT @giobatdauca = GioKetThuc, @gioketthucca = GioKetThuc </p><p>FROM dbo.PhanCong INNER JOIN Ca ON Ca.MaCa = PhanCong.MaCa </p><p>`	`WHERE @mapc = MaPC</p><p>`	`SET @giobatdauca = DATEADD(MINUTE, -5, @giobatdauca)</p><p>`	`SET @gioketthucca = DATEADD(MINUTE, 5, @gioketthucca)</p><p>`	`IF @giobatdauca <= @giokt AND @giokt <= @gioketthucca</p><p>`		`UPDATE dbo.ChamCong SET GioKT = @giokt WHERE MaPC = @mapc</p><p>`	`ELSE </p><p>`		`RAISERROR('Bạn đã nhập giờ kết thúc không nằm trong khoảng thời gian được phân công!', 16, 1)</p><p>END</p>|
| - |

<a name="_toc134389952"></a><a name="_toc134397085"></a>**3.2.16 Hàm Tính Lương một Chấm Công**

|<p>CREATE FUNCTION TinhLuongCC(@mapc INT)</p><p>RETURNS FLOAT</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @luongtheogio FLOAT</p><p>`	`SELECT @luongtheogio = LuongTheoGio FROM dbo.ChamCong, dbo.PhanCong, dbo.NhanVien, dbo.ChucVu</p><p>`	`WHERE ChamCong.MaPC = dbo.PhanCong.MaPC AND dbo.PhanCong.MaNV = dbo.NhanVien.MaNV AND dbo.NhanVien.MaCV = dbo.ChucVu.MaCV AND ChamCong.MaPC = @mapc</p><p></p><p>`	`DECLARE @maca NVARCHAR(255)</p><p>`	`SELECT @maca = MaCa FROM dbo.ChamCong, dbo.PhanCong, dbo.NhanVien, dbo.ChucVu</p><p>`	`WHERE ChamCong.MaPC = dbo.PhanCong.MaPC AND dbo.PhanCong.MaNV = dbo.NhanVien.MaNV AND dbo.NhanVien.MaCV = dbo.ChucVu.MaCV AND ChamCong.MaPC = @mapc</p><p></p><p>`	`DECLARE @result FLOAT</p><p></p><p>`	`IF @maca LIKE 'E'</p><p>`	`BEGIN</p><p>`		`SET @result = @luongtheogio \* 6</p><p>`		`SET @result = @result \* 125 / 100</p><p>`    `END</p><p>`	`ELSE</p><p>`		`SET @result = @luongtheogio \* 4</p><p></p><p>`	`DECLARE @ngaychamcong DATE</p><p>`	`SELECT @ngaychamcong = NgayDangKy FROM dbo.ChamCong, dbo.PhanCong, dbo.NhanVien, dbo.ChucVu</p><p>`	`WHERE ChamCong.MaPC = dbo.PhanCong.MaPC AND dbo.PhanCong.MaNV = dbo.NhanVien.MaNV AND dbo.NhanVien.MaCV = dbo.ChucVu.MaCV AND ChamCong.MaPC = @mapc</p><p>`	`IF EXISTS(SELECT \* FROM dbo.NgayLe WHERE @ngaychamcong = Ngay)</p><p>`		`SET @result = @result \* 3</p><p></p><p>`	`RETURN @result</p><p>END</p>|
| - |

<a name="_toc134389953"></a><a name="_toc134397086"></a>**3.2.17  Lương**

Thủ tục thêm tính lương

|<p>CREATE PROCEDURE ThemTinhLuong</p><p>@mapc INT</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @luongca FLOAT</p><p>`	`DECLARE @manv NVARCHAR(255)</p><p>`	`DECLARE @ngay DATE</p><p></p><p>`	`SELECT @luongca = Luong, @manv = NhanVien.MaNV, @ngay = NgayDangKy FROM dbo.ChamCong, dbo.PhanCong, dbo.NhanVien, dbo.ChucVu</p><p>`	`WHERE ChamCong.MaPC = dbo.PhanCong.MaPC</p><p>`		`AND dbo.PhanCong.MaNV = dbo.NhanVien.MaNV</p><p>`		`AND dbo.NhanVien.MaCV = dbo.ChucVu.MaCV</p><p>`		`AND ChamCong.MaPC = @mapc</p><p></p><p>`	`IF EXISTS(SELECT \* FROM dbo.TinhLuong WHERE MaNV = @manv AND Ngay = @ngay)</p><p>`		`UPDATE dbo.TinhLuong SET TongLuong += @luongca WHERE MaNV = @manv AND Ngay = @ngay</p><p>`	`ELSE</p><p>`		`INSERT INTO dbo.TinhLuong</p><p>`		`(</p><p>`			`MaNV,</p><p>`			`Ngay,</p><p>`			`TongLuong</p><p>`		`)</p><p>`		`VALUES</p><p>`		`(   @manv,       -- MaNV - nvarchar(10)</p><p>`			`@ngay, -- Ngay - date</p><p>`			`@luongca        -- TongLuong - float</p><p>`		`)</p><p>END</p>|
| - |

Thủ tục sửa tính lương

|<p>CREATE PROCEDURE UpdateTinhLuong</p><p>@mapc INT</p><p>AS</p><p>BEGIN</p><p>`    `UPDATE dbo.ChamCong SET Luong = dbo.TinhLuongCC(@mapc) WHERE MaPC = @mapc</p><p>END</p>|
| :- |

<a name="_toc134397087"></a><a name="_toc134389954"></a>**3.2.18 Hàm bảng chi tiết hóa đơn thanh toán**

|<p>CREATE FUNCTION BangChiTietHoaDonThanhToan()</p><p>RETURNS TABLE</p><p>AS</p><p>RETURN</p><p>(</p><p>`	`SELECT MaSP, NSX, HSD, SoLuong FROM dbo.ChiTietHoaDon WHERE MaHD = dbo.MaxHD()</p><p><a name="_toc134396169"></a><a name="_toc134397088"></a>)</p>|
| :- |

<a name="_toc134397089"></a>**3.2.19 Hàm tính MaxHD**

|<p>CREATE FUNCTION MaxHD()</p><p>RETURNS int</p><p>AS</p><p>BEGIN</p><p>`	`DECLARE @result int</p><p>`	`SELECT @result = MAX(MaHD) FROM dbo.HoaDon</p><p>`	`RETURN @result</p><p>END</p>|
| :- |









<a name="_toc134389955"></a><a name="_toc134397090"></a>**CHƯƠNG 4: TẠO USER VÀ PHÂN QUYỀN**

**Ứng với hai nhóm người dùng( Nhân viên và quản lý) là các role riêng** 

\+ Tạo role nhân viên

|CREATE ROLE RoleNhanVien|
| - |

\+ Quản lý được phân quyền với role là SYSADMIN trong thủ tục thêm nhân viên

|<p>DECLARE @sqltemp2 nvarchar(2000)</p><p>SET @sqltemp2= 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @tentk</p><p>EXEC (@sqltemp2)</p>|
| - |

\+ Đối với Role Nhân Viên: Tạo mới Database Role Nhân Viên và gán các quyền cần thiết cho role 

|<p>GRANT SELECT, UPDATE ON dbo.NhanVien TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_SuaNhanVien TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.MaxHD TO RoleNhanVien</p><p>GRANT SELECT, UPDATE on dbo.CuaHang TO RoleNhanVien</p><p>GRANT SELECT ON dbo.NgayLe TO RoleNhanVien</p><p>GRANT SELECT ON f\_TimKiemKhachHang TO RoleNhanVien</p><p>GRANT SELECT ON f\_TimKiemCuaHang TO RoleNhanVien</p><p>GRANT SELECT ON ViewCuaHang TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE on dbo.ChucVu TO RoleNhanVien</p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.KhachHang TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_ThemKhachHang TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_SuaKhachHang TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_XoaKhachHang TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.HoaDon TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_ThemHoaDon TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_XoaHoaDon TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.UpdateLaiCuaHangKhiThanhToan TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.ChiTietHoaDon TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_ThemChiTietHoaDon TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_XoaChiTietHoaDon TO RoleNhanVien</p><p>GRANT SELECT ON  dbo.ChiTietHoaDonThanhToan TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.PhanCong TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_ThemPhanCong TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.sp\_XoaPhanCong TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.ChamCong TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.UpDateGioBD TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.UpDateGioKT TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.UpdateTinhLuong TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.TinhLuongCC TO RoleNhanVien</p><p></p><p>GRANT SELECT, UPDATE, INSERT ON dbo.TinhLuong TO RoleNhanVien</p><p>GRANT EXECUTE ON dbo.ThemTinhLuong TO RoleNhanVien</p><p></p><p>GRANT SELECT on dbo.PhuongThucThanhToan TO RoleNhanVien</p><p>GRANT SELECT on dbo.SanPham TO RoleNhanVien</p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.Ca TO RoleNhanVien</p><p>GRANT SELECT, UPDATE, INSERT, DELETE on dbo.XemBangPC\_NhanVien TO RoleNhanVien</p>|
| - |




<a name="_toc134397091"></a>**CHƯƠNG 5: THIẾT KẾ GIAO DIỆN HỆ THỐNG**

**Môi trường cài đặt và công nghệ sử dụng** 

\- Hệ cơ sở dữ liệu Microsoft SQL Server Management Studio 18.

` `- Chương trình Winform được viết bằng Microsoft Visual Studio 2022 - trên nền tảng ASP.NET Web Application (.NET Framework) C#.

**Giao diện và chức năng của chương trình:** 

<a name="_toc134397092"></a>**5.1 Form đăng nhập**

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.006.png)
**


<a name="_toc134397093"></a>**5.2 Form home**

\- Đối với nhân viên:

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.007.png)

\- Đối với quản lý

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.008.png)

<a name="_toc134397094"></a>**5.3 Thao tác đăng nhập**

Tạo đối tượng biến toàn cục NhanVien, khi đăng nhập sẽ lưu TenTK và MatKhau nhập vào từ người dùng.

|<p>`        `private void btnLogin\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `Program.nv = nvDAO.KiemTraDangNhap(tbxUserName.Text, tbxPassword.Text);</p><p>`                `if (Program.nv != null)</p><p>`                `{</p><p>`                    `if (rbQuanLy.Checked == true)</p><p>`                    `{</p><p>`                        `if (Program.nv.MaCV == 1)</p><p>`                        `{</p><p>`                            `fQuanLy ql = new fQuanLy(Program.nv);</p><p>`                            `this.Hide();</p><p>`                            `ql.ShowDialog();</p><p>`                            `this.Show();</p><p>`                        `}</p><p>`                        `else</p><p>`                            `MessageBox.Show("Bạn không có quyền truy cập vào quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);</p><p>`                    `}</p><p>`                    `else</p><p>`                    `{</p><p>`                        `fNhanVien form = new fNhanVien(Program.nv);</p><p>`                        `this.Hide();</p><p>`                        `form.ShowDialog();</p><p>`                        `this.Show();</p><p>`                    `}</p><p>`                `}</p><p>`                `else</p><p>`                    `MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);</p><p>`            `}</p><p>`            `catch (Exception ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Đăng nhập thất bại!\n" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`        `}</p>|
| :- |

Nhận đối tượng NhanVien từ TenTK và MatKhau

|<p>`        `public NhanVien KiemTraDangNhap(string tentk, string matkhau)</p><p>`        `{</p><p>`            `string query = string.Format("SELECT \* FROM dbo.NhanVien WHERE TenTK = N'{0}' AND MatKhau = N'{1}'", tentk, matkhau);</p><p>`            `DataTable result = db.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new NhanVien(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
| - |

`	`Kết nối Username và Password của Login SQL vào C#

|<p>`        `SqlConnection conn = null;</p><p></p><p>`        `public DBConnection(NhanVien nv)</p><p>`        `{</p><p>`            `string cnnStr = "Data Source = (localdb)\\mssqllocaldb;Initial Catalog = QuanLyCuaHangTienLoi; " +</p><p>`                              `$"User ID= {nv.TenTK};Password= {nv.MatKhau}";</p><p>`            `conn = new SqlConnection(cnnStr);</p><p>`        `}</p>|
| :- |

<a name="_toc134397095"></a>**5.4 Các hàm kết nối và gọi thực thi chung từ SQL**

Hàm lấy danh sách

|<p>`        `public DataTable LayDanhSach(string sqlStr)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);</p><p>`                `DataTable data = new DataTable();</p><p>`                `adapter.Fill(data);</p><p>`                `return data;</p><p>`            `}</p><p>`            `catch (SqlException ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Lấy danh sách thất bại\n" + ex.Message, "Thông báo");</p><p>`            `}</p><p>`            `finally</p><p>`            `{</p><p>`                `conn.Close();</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
| :- |

Hàm lấy giá trị string

|<p>`        `public String LayGiaTri(string sqlStr)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `SqlCommand cmd = new SqlCommand(sqlStr, conn);</p><p>`                `String data = cmd.ExecuteScalar().ToString();</p><p>`                `return data;</p><p>`            `}</p><p>`            `catch (SqlException ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Lấy giá trị thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`            `finally</p><p>`            `{</p><p>`                `conn.Close();</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
| :- |

Hàm thực thi câu lệnh

|<p>`        `public void Execute(string query)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `SqlCommand cmd = new SqlCommand(query, conn);</p><p></p><p>`                `if (cmd.ExecuteNonQuery() < 0)</p><p>`                    `MessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`            `catch (SqlException ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`            `finally</p><p>`            `{</p><p>`                `conn.Close();</p><p>`            `}</p><p>`        `}</p>|
| :- |

<a name="_toc134397096"></a>**5.5 Các hàm gọi thủ tục, hàm, view từ SQL trong lớp DAO (Data Access Object)**

<a name="_toc134397097"></a>**5.5.1 Ca**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach("Select \* from Ca");</p><p>`        `}</p>|
| - |
|<p>`        `public Ca LayThongTinCaBangMaCa(string macv)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.Ca WHERE MaCa = N'{macv}'");</p><p>`            `DataTable result = exec.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new Ca(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|

<a name="_toc134397098"></a>**5.5.2 Chấm công**

|<p>`        `public DataTable LayDanhSach(int mapc)</p><p>`        `{</p><p>`            `return exec.LayDanhSach($"Select \* from ChamCong WHERE MaPC = {mapc}");</p><p>`        `}</p>|
| :- |
|<p>`        `public void CheckIn(ChamCong cc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.UpDateGioBD @mapc = {cc.MaPC}," +</p><p>`                                                              `$"@giobd = '{cc.GioBD}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void CheckOut(ChamCong cc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.UpDateGioKT @mapc = {cc.MaPC}," +</p><p>`                                                              `$"@giokt = '{cc.GioKT}'");</p><p>`            `exec.Execute(query);</p><p>`            `TinhLuong(cc);</p><p>`            `ThemTinhLuong(cc);</p><p>`        `}</p>|
|<p>`        `public void TinhLuong(ChamCong cc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.UpdateTinhLuong @mapc = {cc.MaPC}");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void ThemTinhLuong(ChamCong cc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.ThemTinhLuong @mapc = {cc.MaPC}");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public ChamCong LayThongTinChamCongBangMaPC(int mapc)</p><p>`        `{</p><p>`            `string query = string.Format("SELECT \* FROM dbo.ChamCong WHERE MaPC = {0}", mapc);</p><p>`            `DataTable result = exec.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new ChamCong(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|

<a name="_toc134397099"></a>**5.5.3 Chi tiết hóa đơn**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from ChiTietHoaDon";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| - |
|<p>`        `public DataTable LayDanhSachTheoHoaDon(int mahd)</p><p>`        `{</p><p>`            `string sql = $"Select \* from ChiTietHoaDon Where mahd = {mahd}";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>**	        public DataTable LayDanhSachThanhToan()</p><p>`        `{</p><p>`            `string sql = "Select \* from ChiTietHoaDonThanhToan";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public void Order(ChiTietHoaDon cthd)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_ThemChiTietHoaDon @mahd = N'{cthd.MaHD}'," +</p><p>`                                                                `$"@masp= N'{cthd.MaSP}'," +</p><p>`                                                                `$"@nsx = N'{cthd.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@hsd = N'{cthd.HSD.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@sl = N'{cthd.SoLuong}'");</p><p>`            `db.Execute(query);</p><p>            </p><p>`        `}</p>|
|<p>`        `public DataTable LayDanhSachThanhToanRong()</p><p>`        `{</p><p>`            `string sql = "Select \* from ChiTietHoaDonThanhToan Where 0=1";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|

<a name="_toc134397100"></a>**5.5.4 Chức vụ**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach("Select \* from ChucVu");</p><p>`        `}</p>|
| - |
|<p>`        `public ChucVu LayThongTinChucVuBangMaCV(int macv)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.ChucVu WHERE MaCV = {macv}");</p><p>`            `DataTable result = exec.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new ChucVu(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|

<a name="_toc134397101"></a>**5.5.5 Cửa hàng**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "select \* from viewcuahang";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| :- |
|<p>**	        public DataTable LayDanhSach\_ConHan()</p><p>`        `{</p><p>`            `string sql = "select \* from viewcuahang WHERE HSD >= GetDATE()";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public DataTable LayDanhSach\_HetHan()</p><p>`        `{</p><p>`            `string sql = "select \* from viewcuahang WHERE HSD < GetDATE()";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public void XuatKho(CuaHang ch)</p><p>`        `{</p><p></p><p>`            `string query = String.Format($"EXEC dbo.sp\_XuatKho @masp = N'{ch.MaSP}'," +</p><p>`                                                                `$"@nsx = N'{ch.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@hsd = N'{ch.HSD.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@ngayxuatkho = N'{ch.NgayXuatKho.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@soluong = N'{ch.SoLuong}'");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>**	        public void TraKho(CuaHang ch)</p><p>`        `{</p><p></p><p>`            `string query = String.Format($"EXEC dbo.sp\_TraKho @masp = N'{ch.MaSP}'," +</p><p>`                                                                `$"@nsx = N'{ch.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@hsd = N'{ch.HSD.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@ngayxuatkho = N'{ch.NgayXuatKho.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@soluong = N'{ch.SoLuong}'");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemCuaHang(N'{find}')");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem\_ConHan(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemCuaHang(N'{find}') WHERE HSD >= GetDATE()");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem\_HetHan(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemCuaHang(N'{find}') WHERE HSD < GetDATE()");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397102"></a>**5.5.6 Hóa đơn**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from HoaDon";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| :- |
|<p>`        `public DataTable LayDanhSachTheoKhachHang(int sdtkh)</p><p>`        `{</p><p>`            `string sql = $"Select \* from HoaDon Where SDTKH = {sdtkh}";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>**	        public void ThanhToan()</p><p>`        `{</p><p>`            `string sql = $"EXECUTE dbo.UpdateLaiCuaHangKhiThanhToan";</p><p>`            `db.Execute(sql);</p><p>`        `}</p>|
|<p>`        `public void HuyThanhToan(int mahd)</p><p>`        `{</p><p>`            `string sql = $"EXECUTE dbo.sp\_XoaHoaDon @mahd = {mahd}";</p><p>`            `db.Execute(sql);</p><p>`        `}</p>|
|<p>`        `public void TaoHD()</p><p>`        `{</p><p>`            `string sql = "EXEC dbo.sp\_ThemHoaDon @manv = NULL,  @sdtkh = NULL, @pttt = NULL";</p><p>`            `db.Execute(sql);</p><p>`        `}</p>|
|<p>`        `public int MaxHD()</p><p>`        `{</p><p>`            `string query = String.Format("SELECT dbo.MaxHD()");</p><p>`            `return Convert.ToInt32(db.LayGiaTri(query));</p><p>`        `}</p>|
|<p>`        `public void TaoHD(HoaDon hd)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_ThemHoaDon @manv = N'{hd.MaNV}'," +</p><p>`                                                                `$"@sdtkh = {hd.SdtKH}," +</p><p>`                                                                `$"@pttt = N'{hd.PTTT}'");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public string TinhDoanhThu()</p><p>`        `{</p><p>`            `string sql = "SELECT dbo.TinhDoanhThu()";</p><p>`            `return db.LayGiaTri(sql);</p><p>`        `}</p>|
|<p>`        `public DataTable LocDoanhThu(DateTime Tu, DateTime Den)</p><p>`        `{</p><p>`            `string sql = $"Select \* From dbo.LocDoanhThu('{Tu.ToString("yyyy-MM-dd")}', '{Den.ToString("yyyy-MM-dd")}')";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|

<a name="_toc134397103"></a>**5.5.7 Khách hàng**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from KhachHang";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| :- |
|<p>`        `public void Them(KhachHang kh)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_ThemKhachHang @sdt = N'{kh.Sdt}'," +</p><p>`                                                                `$"@tenkh = N'{kh.TenKH}'," +</p><p>`                                                                `$"@diemtichluy = N'{kh.DiemTichLuy}'");</p><p>                                                               </p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Sua(KhachHang kh)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_SuaKhachHang @sdt = N'{kh.Sdt}'," +</p><p>`                                                                `$"@tenkh = N'{kh.TenKH}'," +</p><p>`                                                                `$"@diemtichluy = N'{kh.DiemTichLuy}'");</p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Xoa(KhachHang kh)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_XoaKhachHang @sdt = N'{kh.Sdt}'");</p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemKhachHang(N'{find}')");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397104"></a>**5.5.8 Kho**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from ViewKho";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| - |
|<p>**	        public DataTable LayDanhSach\_ConHan()</p><p>`        `{</p><p>`            `string sql = "select \* from ViewKho WHERE HSD >= GetDATE()";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public DataTable LayDanhSach\_HetHan()</p><p>`        `{</p><p>`            `string sql = "select \* from ViewKho WHERE HSD < GetDATE()";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public void NhapKho(Kho k)</p><p>`        `{</p><p>`            `string query = String.Format(</p><p>`                                            `$"EXEC dbo.sp\_NhapKho @masp = N'{k.MaSP}'," +</p><p>`                                            `$"@nsx = N'{k.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                            `$"@hsd = N'{k.HSD.ToString("yyyy-MM-dd")}'," +</p><p>`                                            `$"@ngaynhapkho = N'{k.NgayNhapKho.ToString("yyyy-MM-dd")}'," +</p><p>`                                            `$"@loaikho = N'{k.LoaiKho}'," +</p><p>`                                            `$"@sltonkho = N'{k.SLTonKho}'"</p><p>`            `);</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Sua(Kho k)</p><p>`        `{</p><p></p><p>`            `string query = String.Format($"EXEC dbo.sp\_SuaSPvaoKho @masp = N'{k.MaSP}'," +</p><p>`                                                                `$"@nsx = N'{k.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@hsd = N'{k.HSD.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@ngaynhapkho = N'{k.NgayNhapKho.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@loaikho = N'{k.LoaiKho}'," +</p><p>`                                                                `$"@sltonkho = N'{k.SLTonKho}'");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Xoa(Kho k)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_XoaSPvaoKho @masp = N'{k.MaSP}'," +</p><p>`                                                                `$"@nsx = N'{k.NSX.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@hsd = N'{k.HSD}'");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemKho(N'{find}')");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem\_ConHan(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemKho(N'{find}') WHERE HSD >= GetDATE()");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem\_HetHan(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemKho(N'{find}') WHERE HSD < GetDATE()");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397105"></a>**5.5.9 Ngày lễ**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach("Select \* from NgayLe");</p><p>`        `}</p>|
| - |
|<p>`        `public void Them(NgayLe nl)</p><p>`        `{</p><p>`            `string query = string.Format($"EXECUTE dbo.sp\_ThemNgayLe @ngay = '{nl.Ngay.ToString("yyyy-MM-dd")}', " +</p><p>`                                         `$"@sukien = N'{nl.SuKien}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Sua(NgayLe nl)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.sp\_SuaNgayLe @manl = {nl.MaNL}, " +</p><p>`                                            `$"@ngay = '{nl.Ngay.ToString("yyyy-MM-dd")}', " +</p><p>`                                            `$"@sukien = N'{nl.SuKien}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Xoa(NgayLe nl)</p><p>`        `{</p><p>`            `string query = string.Format($"EXECUTE dbo.sp\_XoaNgayLe @manl = {nl.MaNL}");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|

<a name="_toc134397106"></a>**5.5.10 Nhân viên**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from NhanVien";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| - |
|<p>`        `public DataTable LayDanhSach(int trangthai)</p><p>`        `{</p><p>`            `string sql = $"Select \* from NhanVien where TrangThai = {trangthai}";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public void Them(NhanVien nv)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_ThemNhanVien @tennv = N'{nv.TenNV}'," +</p><p>`                                                                `$"@sdt = N'{nv.Sdt}'," +</p><p>`                                                                `$"@phai = {nv.Phai}," +</p><p>`                                                                `$"@ngaysinh = N'{nv.NgaySinh.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@email = N'{nv.Email}'," +</p><p>`                                                                `$"@macv = {nv.MaCV}," +</p><p>`                                                                `$"@trangthai = {nv.TrangThai}," +</p><p>`                                                                `$"@tentk = N'{nv.TenTK}'," +</p><p>`                                                                `$"@matkhau = N'{nv.MatKhau}'" );</p><p>`            `db.Execute(query);</p><p>`            `NhanVien nNV = LayThongTinNhanVienBangTenTK(nv.TenTK);</p><p>`            `nv.MaNV = nNV.MaNV;</p><p>`            `if (nv.Hinh != null)</p><p>`            `{</p><p>`                `LuuAnh(nv, nv.Hinh);</p><p>`            `}</p><p>`        `}</p>|
|<p>`        `public void Sua(NhanVien nv) </p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_SuaNhanVien @manv = N'{nv.MaNV}'," +</p><p>`                                                                `$"@tennv = N'{nv.TenNV}'," +</p><p>`                                                                `$"@sdt = N'{nv.Sdt}'," +</p><p>`                                                                `$"@phai = {nv.Phai}," +</p><p>`                                                                `$"@ngaysinh = N'{nv.NgaySinh.ToString("yyyy-MM-dd")}'," +</p><p>`                                                                `$"@email = N'{nv.Email}'," +</p><p>`                                                                `$"@macv = {nv.MaCV}," +</p><p>`                                                                `$"@trangthai = {nv.TrangThai}," +</p><p>`                                                                `$"@tentk = N'{nv.TenTK}'," +</p><p>`                                                                `$"@matkhau = N'{nv.MatKhau}'");</p><p>`            `db.Execute(query);</p><p>`            `if (nv.Hinh != null)</p><p>`            `{</p><p>`                `LuuAnh(nv, nv.Hinh);</p><p>`            `}</p><p>`        `}</p>|
|<p>`        `public void Xoa(NhanVien nv)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_XoaNhanVien @manv = N'{nv.MaNV}'");</p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public NhanVien LayThongTinNhanVienBangTenTK(string tentk)</p><p>`        `{</p><p>`            `string query = string.Format("SELECT \* FROM dbo.NhanVien WHERE TenTK = N'{0}'", tentk);</p><p>`            `DataTable result = db.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new NhanVien(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
|<p>`        `public NhanVien LayThongTinNhanVienBangMaNV(string manv)</p><p>`        `{</p><p>`            `string query = string.Format("SELECT \* FROM dbo.NhanVien WHERE MaNV = N'{0}'", manv);</p><p>`            `DataTable result = db.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new NhanVien(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemNhanVien(N'{find}')");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find, int trangthai)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemNhanVien(N'{find}') where TrangThai = {trangthai}");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397107"></a>**5.5.11 Nhà sản xuất**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach("Select \* from NhaSanXuat");</p><p>`        `}</p>|
| - |
|<p>`        `public void Them(NhaSanXuat nsx)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.sp\_ThemNSX @tennsx = N'{nsx.TenNSX}'," +</p><p>`                                        `$"@diachi = N'{nsx.DiaChi}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Sua(NhaSanXuat nsx)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.sp\_SuaNSX @mansx = {nsx.MaNSX}, " +</p><p>`                                        `$"@tennsx = N'{nsx.TenNSX}', " +</p><p>`                                        `$"@diachi = N'{nsx.DiaChi}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Xoa(NhaSanXuat nsx)</p><p>`        `{</p><p>`            `string query = string.Format($"EXECUTE dbo.sp\_XoaNSX @mansx = {nsx.MaNSX}");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|

<a name="_toc134397108"></a>**5.5.12 Phân công**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach("Select \* from XemBangPC\_NhanVien");</p><p>`        `}</p>|
| - |
|<p>`        `public DataTable LayDanhSach(string manv)</p><p>`        `{</p><p>`            `return exec.LayDanhSach($"Select \* from XemBangPC\_NhanVien WHERE MaNV = N'{manv}'");</p><p>`        `}</p>|
|<p>`        `public PhanCong LayThongTinPhanCongBangMaPC(int macv)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.PhanCong WHERE MaPC = {macv}");</p><p>`            `DataTable result = exec.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new PhanCong(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
|<p>`        `public void Them(PhanCong pc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.sp\_ThemPhanCong " +</p><p>`                                            `$"@manv = N'{pc.MaNV}'," +</p><p>`                                            `$"@maca = N'{pc.MaCa}'," +</p><p>`                                            `$"@ngaydangky = '{pc.NgayDangKy.ToString("yyyy-MM-dd")}'");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public void Xoa(PhanCong pc)</p><p>`        `{</p><p>`            `string query = string.Format($"EXEC dbo.sp\_XoaPhanCong @mapc = {pc.MaPC}");</p><p>`            `exec.Execute(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemPhanCong(N'{find}')");</p><p>`            `return exec.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397109"></a>**5.5.13 Phương thức thanh toán**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from PhuongThucThanhToan";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| - |

<a name="_toc134397110"></a>**5.5.14 Sản phẩm**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `string sql = "Select \* from SanPham";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
| - |
|<p>`        `public DataTable LayDanhSach(int trangthai)</p><p>`        `{</p><p>`            `string sql = $"Select \* from SanPham where TrangThai = {trangthai}";</p><p>`            `return db.LayDanhSach(sql);</p><p>`        `}</p>|
|<p>`        `public void Them(SanPham sp)</p><p>`        `{</p><p></p><p>`            `string query = String.Format($"EXEC dbo.sp\_ThemSanPham @tensp = N'{sp.TenSP}'," +</p><p>`                                                                `$"@mansx= {sp.MaNSX}," +</p><p>`                                                                `$"@maloai = {sp.MaLoai}," +</p><p>`                                                                `$"@giaban = {sp.GiaBan}," +</p><p>`                                                                `$"@giagoc = {sp.GiaGoc}," +</p><p>`                                                                `$"@trangthai = {sp.TrangThai}");</p><p>`            `db.Execute(query);</p><p>`            `SanPham nSP = LayThongTinSP(sp);</p><p>`            `sp.MaSP = nSP.MaSP;</p><p>`            `if (sp.Hinh != null)</p><p>`            `{</p><p>`                `LuuAnh(sp, sp.Hinh);</p><p>`            `}</p><p>`        `}</p>|
|<p>`        `public void Sua(SanPham sp)</p><p>`        `{</p><p>            </p><p>`            `string query = String.Format($"EXEC dbo.sp\_SuaSanPham @masp = {sp.MaSP}," +</p><p>`                                                                `$"@tensp = N'{sp.TenSP}'," +</p><p>`                                                                `$"@mansx= {sp.MaNSX}," +</p><p>`                                                                `$"@maloai = {sp.MaLoai}," +</p><p>`                                                                `$"@giaban = {sp.GiaBan}," +</p><p>`                                                                `$"@giagoc = {sp.GiaGoc}," +</p><p>`                                                                `$"@trangthai = {sp.TrangThai}");</p><p>`            `db.Execute(query);</p><p>`            `if (sp.Hinh != null)</p><p>`            `{</p><p>`                `LuuAnh(sp, sp.Hinh);</p><p>`            `}</p><p>`        `}</p>|
|<p>`        `public void Xoa(SanPham sp)</p><p>`        `{</p><p>`            `string query = String.Format($"EXEC dbo.sp\_XoaSanPham @masp = {sp.MaSP}");</p><p></p><p>`            `db.Execute(query);</p><p>`        `}</p>|
|<p>`        `public SanPham LayThongTinSP(SanPham sp)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.SanPham WHERE TenSP = N'{sp.TenSP}' and " +</p><p>`                                        `$"MaNSX= {sp.MaNSX} and " +</p><p>`                                        `$"MaLoai = {sp.MaLoai} and " +</p><p>`                                        `$"GiaBan = {sp.GiaBan} and " +</p><p>`                                        `$"GiaGoc = {sp.GiaGoc} and " +</p><p>`                                        `$"TrangThai = '{sp.TrangThai}'");</p><p>`            `DataTable result = db.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new SanPham(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
|<p>`        `public SanPham LayThongTinSanPhamBangMaSP(int masp)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.SanPham WHERE MaSP = {masp}");</p><p>`            `DataTable result = db.LayDanhSach(query);</p><p></p><p>`            `foreach (DataRow dr in result.Rows)</p><p>`            `{</p><p>`                `return new SanPham(dr);</p><p>`            `}</p><p>`            `return null;</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemSanPham(N'{find}')");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|
|<p>`        `public DataTable TimKiem(string find, int trangthai)</p><p>`        `{</p><p>`            `string query = string.Format($"SELECT \* FROM dbo.f\_TimKiemSanPham(N'{find}') where TrangThai = {trangthai}");</p><p>`            `return db.LayDanhSach(query);</p><p>`        `}</p>|

<a name="_toc134397111"></a>**5.5.15 Tính lương**

|<p>`        `public DataTable LayDanhSach()</p><p>`        `{</p><p>`            `return exec.LayDanhSach($"Select \* from TinhLuong");</p><p>`        `}</p>|
| - |
|<p>`        `public DataTable LayDanhSach(string manv)</p><p>`        `{</p><p>`            `return exec.LayDanhSach($"Select \* from TinhLuong WHERE MaNV = '{manv}'");</p><p>`        `}</p>|

<a name="_toc134397112"></a>**5.6 Các form danh mục**

<a name="_toc134397113"></a>**5.6.1 Đăng nhập với tư cách là nhân viên**

**5.6.1.1 Form thông tin cá nhân**

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.009.png)

Người dùng có thể tải ảnh cá nhân và lưu ảnh

|<p>`        `public void LuuAnh(NhanVien nv, byte[] anh)</p><p>`        `{</p><p>`            `nv.Hinh = anh;</p><p>`            `using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr))</p><p>`            `{</p><p>`                `conn.Open();</p><p>`                `using (SqlCommand command = new SqlCommand("UPDATE dbo.NhanVien SET Hinh = @anh WHERE MaNV = @id ", conn))</p><p>`                `{</p><p>`                    `command.Parameters.AddWithValue("@id", nv.MaNV);</p><p>`                    `command.Parameters.AddWithValue("@anh", anh);</p><p></p><p>`                    `if (command.ExecuteNonQuery() > 0)</p><p>`                        `MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);</p><p>`                    `else MessageBox.Show("Thao tác thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`                `}</p><p>`                `conn.Close();</p><p>`            `}</p><p>`        `}</p>|
| :- |

**5.6.1.2 Form thanh toán**

Trước khi thực hiện thanh toán, người dùng phải bấm vào nút tạo hóa đơn với SĐT khách hàng được ghi nhận. Người dùng chọn vào một bộ trong sản phẩm của cửa hàng để chọn món và thanh toán, ngược lại có thể hủy hóa đơn nếu thông tin hóa đơn có sai sót bằng nút hủy.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.010.png)

Tạo hóa đơn

|<p>`        `private void btnTaoHD\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `string sdtkh = tbSDTKH.Text.ToString();</p><p>`            `if (sdtkh == "")</p><p>`                `sdtkh = "NULL";</p><p>`            `else</p><p>`                `sdtkh = "'" + sdtkh + "'";</p><p>`            `HoaDon hd = new HoaDon(tbMaNV.Text, sdtkh, Convert.ToInt32(cbPTTT.SelectedValue.ToString()));</p><p>`            `hdDAO.TaoHD(hd);</p><p>`            `btnTaoHD.Enabled = false;</p><p>`            `btnOrder.Enabled = true;</p><p>`            `btnHuy.Enabled = true;</p><p>`            `btnThanhToan.Enabled = true;</p><p>`        `}</p>|
| :- |

Thao tác Order

|<p>`        `private void btnOrder\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `int mahd = hdDAO.MaxHD();</p><p>`            `ChiTietHoaDon cthd = new ChiTietHoaDon(mahd, Convert.ToInt32(tbMaSPCuaHang.Text), (DateTime)this.dtpkNSXCuaHang.Value,</p><p>`                `(DateTime)this.dtpkHSDCuaHang.Value, Convert.ToInt32(this.tbSoLuong.Text));</p><p>`            `cthdDAO.Order(cthd);</p><p>`            `dgvChiTietHoaDon.DataSource = cthdDAO.LayDanhSachThanhToan();</p><p>`        `}</p>|
| :- |

Thanh toán

|<p>`        `private void btnThanhToan\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `int mahd = hdDAO.MaxHD();</p><p>`            `hdDAO.ThanhToan();</p><p>`            `LoadDanhSach();</p><p>`            `dgvChiTietHoaDon.DataSource = cthdDAO.LayDanhSachThanhToanRong();</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Hủy hóa đơn thanh toán

|<p>`        `private void btnHuy\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `int mahd = hdDAO.MaxHD();</p><p>`            `hdDAO.HuyThanhToan(mahd);</p><p>`            `dgvChiTietHoaDon.DataSource = null;</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Tìm kiếm

|<p>`        `void TimKiem()</p><p>`        `{</p><p>`            `if (cbLoaiCuaHang.Text == "Tất cả")</p><p>`            `{</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem(tbTimKiem.Text);</p><p>`            `}</p><p>`            `else if (cbLoaiCuaHang.Text == "Còn hạn")</p><p>`            `{</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem\_ConHan(tbTimKiem.Text);</p><p>`            `}</p><p>`            `else</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem\_HetHan(tbTimKiem.Text);</p><p>`        `}</p>|
| - |

**5.6.1.3 Form chấm công (NhanVien)**

Nhân viên chỉ được xem bảng đăng ký phân công của riêng mình. Chỉ được xem bảng NgayLe nhưng không chỉnh sửa được. Người dùng chọn vào một bộ trên bảng phân công sẽ hiện thông tin bên bảng chấm công và có thể thực hiện check in và check out theo thời gian chỉ định.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.011.png)

Đăng ký phân công

|<p>`        `private void btDangKy\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `PhanCong pc = new PhanCong(0, tbMaNV.Text, cbMaCa.Text, dtpkNgayDK.Value);</p><p>`            `pcDAO.Them(pc);</p><p>`            `LoadDanhSach();</p><p>`        `}</p>|
| - |

Xóa đăng ký

|<p>`        `private void btXoa\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `PhanCong pc = new PhanCong(Convert.ToInt32(tbMaPC.Text), tbMaNV.Text, cbMaCa.Text, DateTime.Today);</p><p>`            `pcDAO.Xoa(pc);</p><p>`            `LoadDanhSach();</p><p>`        `}</p>|
| - |

Check in

|<p>`        `private void btCheckIn\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `ChamCong cc = new ChamCong(Convert.ToInt32(tbMaPC.Text), TimeSpan.Parse(tbGioChamCong.Text), null, null);</p><p>`                `ccDAO.CheckIn(cc);</p><p>`                `dtgvChamCong.DataSource = ccDAO.LayDanhSach(cc.MaPC);</p><p>`            `}</p><p>`            `catch (Exception ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Check out thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`        `}</p>|
| - |

Check out

|<p>`        `private void btCheckOut\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `ChamCong cc = new ChamCong(Convert.ToInt32(tbMaPC.Text), null, TimeSpan.Parse(tbGioChamCong.Text), null);</p><p></p><p>`                `dtgvChamCong.CurrentRow.Selected = true;</p><p>`                `if (dtgvChamCong.SelectedRows[0].Cells[1].Value.ToString() != "" && dtgvChamCong.SelectedRows[0].Cells[2].Value.ToString() == "")</p><p>`                `{</p><p>`                    `ccDAO.CheckOut(cc);</p><p>`                    `dtgvChamCong.DataSource = ccDAO.LayDanhSach(cc.MaPC);</p><p>`                `}</p><p>`                `else</p><p>`                    `throw new Exception();</p><p>`            `}</p><p>`            `catch (Exception ex)</p><p>`            `{</p><p>`                `MessageBox.Show("Check out thất bại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);</p><p>`            `}</p><p>`        `}</p>|
| - |

**5.6.1.4 Form quản lý khách hàng**

Người dùng có thể thực hiện các thao tác như thêm, xóa, sửa thông tin của khách hàng. Khi chọn một hàng trên bảng thông tin khách hàng, sẽ có thể xem được những hóa đơn và chi tiết hóa đơn mà khách hàng ấy đã mua.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.012.png)

Thêm khách hàng

|<p>`        `private void btnThem\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `KhachHang kh = new KhachHang(tbSDT.Text, tbTenKH.Text, Convert.ToDouble(tbDTL.Text.ToString()));</p><p>`            `khDAO.Them(kh);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Sửa khách hàng

|<p>`        `private void btnSua\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `KhachHang kh = new KhachHang(tbSDT.Text, tbTenKH.Text, Convert.ToInt32(tbDTL.Text.ToString()));</p><p>`            `khDAO.Sua(kh);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Xóa khách hàng

|<p>`        `private void btnXoa\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `KhachHang kh = new KhachHang(tbSDT.Text);</p><p>`            `khDAO.Xoa(kh);</p><p>`            `LoadData();</p><p>`        `}</p>|
| - |

<a name="_toc134397114"></a>**5.6.2 Đăng nhập với tư cách là quản lý**

**5.6.2.1 Quản lý nhân viên**

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.013.png)

Thêm nhân viên

|<p>`        `private void btnThem\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhanVien nv = new NhanVien(tbTenNV.Text, tbSDT.Text, chbPhai.Checked, dtpkNgaySinh.Value, tbEmail.Text, cbMaCV.SelectedIndex+1, chbTrangThai.Checked, tbTenTK.Text, tbMatKhau.Text, (ptHinh.Image != null) ? nvDAO.ChuyenAnhThanhMangByte(ptHinh) : null);</p><p>`            `nvDAO.Them(nv);</p><p>`            `LoadDanhSach();</p><p>`        `}</p>|
| :- |

Sửa nhân viên

|<p>`        `private void btnSua\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhanVien nv = new NhanVien(tbMaNV.Text, tbTenNV.Text, tbSDT.Text, chbPhai.Checked, dtpkNgaySinh.Value, tbEmail.Text, cbMaCV.SelectedIndex + 1, chbTrangThai.Checked, tbTenTK.Text, tbMatKhau.Text, (ptHinh.Image != null) ? nvDAO.ChuyenAnhThanhMangByte(ptHinh) : null);</p><p>`            `nvDAO.Sua(nv);</p><p>`            `LoadDanhSach();</p><p>`        `}</p>|
| :- |

Xóa nhân viên

|<p>`        `private void btnXoa\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhanVien nv = new NhanVien(tbMaNV.Text);</p><p>`            `nvDAO.Xoa(nv);</p><p>`            `LoadDanhSach();</p><p>`        `}</p>|
| - |

Tìm kiếm nhân viên

|<p>`        `void TimKiem()</p><p>`        `{</p><p>`            `if (cbLoai.Text == "Tất cả")</p><p>`            `{</p><p>`                `dgvNhanVien.DataSource = nvDAO.TimKiem(tbTimKiem.Text);</p><p>`            `}</p><p>`            `else if (cbLoai.Text == "Còn làm việc")</p><p>`            `{</p><p>`                `dgvNhanVien.DataSource = nvDAO.TimKiem(tbTimKiem.Text, 1);</p><p>`            `}</p><p>`            `else</p><p>`                `dgvNhanVien.DataSource = nvDAO.TimKiem(tbTimKiem.Text, 0);</p><p></p><p>`            `DataTable dtcv = new DataTable();</p><p>`            `dtcv = cvDAO.LayDanhSach();</p><p>`            `(dgvNhanVien.Columns["MaCV"] as DataGridViewComboBoxColumn).DataSource = dtcv;</p><p>`            `(dgvNhanVien.Columns["MaCV"] as DataGridViewComboBoxColumn).DisplayMember = "TenCV";</p><p>`            `(dgvNhanVien.Columns["MaCV"] as DataGridViewComboBoxColumn).ValueMember = "MaCV";</p><p>`        `}</p>|
| :- |

**

**5.6.2.2 Quản lý nhập kho**

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.014.png)

1) **Sản phẩm**

Thêm

|<p>`        `private void btnThem\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `SanPham sp = new SanPham(tbTenSP.Text, Convert.ToInt32(tbMaNSX.Text), Convert.ToInt32(tbMaLoai.Text),</p><p>`                `Convert.ToInt32(tbGiaBan.Text), Convert.ToInt32(tbGiaGoc.Text), chbTrangThaiSP.Checked,</p><p>`                `(ptHinhSP.Image != null) ? nvDAO.ChuyenAnhThanhMangByte(ptHinhSP) : null);</p><p>`            `spDAO.Them(sp);</p><p>`            `LoadDataSP();</p><p>`        `}</p>|
| :- |

Xóa

|<p>`        `private void btnXoa\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `SanPham sp = new SanPham(Convert.ToInt32(tbMaSP.Text));</p><p>`            `spDAO.Xoa(sp);</p><p>`            `LoadDataSP();</p><p>`        `}</p>|
| - |

Sửa

|<p>`        `private void btnSua\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `SanPham sp = new SanPham(Convert.ToInt32(tbMaSP.Text), tbTenSP.Text, Convert.ToInt32(tbMaNSX.Text), Convert.ToInt32(tbMaLoai.Text),</p><p>`                `Convert.ToInt32(tbGiaBan.Text), Convert.ToInt32(tbGiaGoc.Text), chbTrangThaiSP.Checked,</p><p>`                `(ptHinhSP.Image != null) ? nvDAO.ChuyenAnhThanhMangByte(ptHinhSP) : null);</p><p>`            `spDAO.Sua(sp);</p><p>`            `LoadDataSP();</p><p>`        `}</p>|
| :- |

Tìm kiếm

|<p>`        `void TimKiemSP()</p><p>`        `{</p><p>`            `if (cbLoai.Text == "Tất cả")</p><p>`            `{</p><p>`                `dgvSanPham.DataSource = spDAO.TimKiem(tbTimKiem.Text);</p><p>`            `}</p><p>`            `else if (cbLoai.Text == "Còn bán")</p><p>`            `{</p><p>`                `dgvSanPham.DataSource = spDAO.TimKiem(tbTimKiem.Text, 1);</p><p>`            `}</p><p>`            `else</p><p>`                `dgvSanPham.DataSource = spDAO.TimKiem(tbTimKiem.Text, 0);</p><p>`        `}</p>|
| - |

1) **Nhà sản xuất**

Thêm

|<p>`        `private void btThemNSX\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhaSanXuat nsx = new NhaSanXuat(0, tbTenNSX.Text, tbDiaChi.Text);</p><p>`            `nsxDAO.Them(nsx);</p><p>`            `tbTenNSX.Text = "";</p><p>`            `tbMaNSX1.Text = "";</p><p>`            `tbDiaChi.Text = "";</p><p>`            `dtgvNSX.DataSource = nsxDAO.LayDanhSach();</p><p>`        `}</p>|
| - |

Xóa

|<p>`        `private void btXoaNSX\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhaSanXuat nsx = new NhaSanXuat(Convert.ToInt32(tbMaNSX1.Text), tbTenNSX.Text, tbDiaChi.Text);</p><p>`            `nsxDAO.Xoa(nsx);</p><p>`            `tbTenNSX.Text = "";</p><p>`            `tbMaNSX1.Text = "";</p><p>`            `tbDiaChi.Text = "";</p><p>`            `dtgvNSX.DataSource = nsxDAO.LayDanhSach();</p><p>`        `}</p>|
| :- |

Sửa

|<p>`        `private void btSuaNSX\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NhaSanXuat nsx = new NhaSanXuat(Convert.ToInt32(tbMaNSX1.Text), tbTenNSX.Text, tbDiaChi.Text);</p><p>`            `nsxDAO.Sua(nsx);</p><p>`            `tbTenNSX.Text = "";</p><p>`            `tbMaNSX1.Text = "";</p><p>`            `tbDiaChi.Text = "";</p><p>`            `dtgvNSX.DataSource = nsxDAO.LayDanhSach();</p><p>`        `}</p>|
| - |

1) **Kho**

Nhập kho

|<p>`        `private void btnNhapKho\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `Kho k = new Kho(Convert.ToInt32(tbMaSPKho.Text), dtpkNSXKho.Value, dtpkHSDKho.Value, dtpkNgayNhapKho.Value, chbLoaiKho.Checked, Convert.ToInt32(tbSLTonKho.Text));</p><p>`            `khoDAO.NhapKho(k);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Sửa

|<p>`        `private void btnSuaKho\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `Kho k = new Kho(Convert.ToInt32(tbMaSPKho.Text), dtpkNSXKho.Value, dtpkHSDKho.Value, dtpkNgayNhapKho.Value, chbLoaiKho.Checked, Convert.ToInt32(tbSLTonKho.Text));</p><p>`            `khoDAO.Sua(k);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Xóa

|<p>`        `private void btnXoaKho\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `Kho k = new Kho(Convert.ToInt32(tbMaSPKho.Text), dtpkNSXKho.Value, dtpkHSDKho.Value);</p><p>`            `khoDAO.Xoa(k);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Tìm kiếm

|<p>`        `void TimKiemKho()</p><p>`        `{</p><p>`            `if (cbLoaiKho.Text == "Tất cả")</p><p>`            `{</p><p>`                `dgvKho.DataSource = khoDAO.TimKiem(btTimKiemKho.Text);</p><p>`            `}</p><p>`            `else if (cbLoaiKho.Text == "Còn hạn")</p><p>`            `{</p><p>`                `dgvKho.DataSource = khoDAO.TimKiem\_ConHan(btTimKiemKho.Text);</p><p>`            `}</p><p>`            `else</p><p>`                `dgvKho.DataSource = khoDAO.TimKiem\_HetHan(btTimKiemKho.Text);</p><p>`        `}</p>|
| - |

**5.6.2.3 Quản lý xuất kho**

Các phương thức, thủ tục của bảng kho thì giống với form quản lý nhập kho.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.015.png)

Xuất kho

|<p>`        `private void btnXuatKho\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `CuaHang ch = new CuaHang(Convert.ToInt32(tbMaSPCuaHang.Text), this.dtpkNSXCuaHang.Value,</p><p>`                `this.dtpkHSDCuaHang.Value, DateTime.Today, Convert.ToInt32(this.tbSoLuong.Text));</p><p>`            `chDAO.XuatKho(ch);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Trả kho

|<p>`        `private void btnTraKho\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `CuaHang ch = new CuaHang(Convert.ToInt32(tbMaSPCuaHang.Text), this.dtpkNSXCuaHang.Value,</p><p>`                `this.dtpkHSDCuaHang.Value, this.dtpkNgayXuatKho.Value, Convert.ToInt32(this.tbSoLuong.Text));</p><p>`            `chDAO.TraKho(ch);</p><p>`            `LoadData();</p><p>`        `}</p>|
| :- |

Tìm kiếm cửa hàng

|<p>`        `void TimKiemCuaHang()</p><p>`        `{</p><p>`            `if (cbLoaiCuaHang.Text == "Tất cả")</p><p>`            `{</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem(tbTimKiemCuaHang.Text);</p><p>`            `}</p><p>`            `else if (cbLoaiCuaHang.Text == "Còn hạn")</p><p>`            `{</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem\_ConHan(tbTimKiemCuaHang.Text);</p><p>`            `}</p><p>`            `else</p><p>`                `dgvCuaHang.DataSource = chDAO.TimKiem\_HetHan(tbTimKiemCuaHang.Text);</p><p>`        `}</p>|
| - |

**

**5.6.2.4 Quản lý phân công**

Người quản lý thực hiện được các thao tác đăng ký ca và chấm công cho mọi nhân viên và có thể chỉnh sửa được bảng ngày lễ.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.016.png)

Thêm ngày lễ

|<p>`        `private void btThemNL\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NgayLe nl = new NgayLe(0, dtpkNL.Value, tbSuKien.Text);</p><p>`            `ngayLeDAO.Them(nl);</p><p>`            `tbSuKien.Text = "";</p><p>`            `tbMaNL.Text = "";</p><p>`            `dtpkNL.Value = DateTime.Today;</p><p>`            `dtgvNgayLe.DataSource = ngayLeDAO.LayDanhSach();</p><p>`        `}</p>|
| - |

Sửa ngày lễ

|<p>`        `private void btSuaNL\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NgayLe nl = new NgayLe(Convert.ToInt32(tbMaNL.Text), dtpkNL.Value, tbSuKien.Text);</p><p>`            `ngayLeDAO.Sua(nl);</p><p>`            `tbSuKien.Text = "";</p><p>`            `tbMaNL.Text = "";</p><p>`            `dtpkNL.Value = DateTime.Today;</p><p>`            `dtgvNgayLe.DataSource = ngayLeDAO.LayDanhSach();</p><p>`        `}</p>|
| - |

Xóa ngày lễ

|<p>`        `private void btXoaNL\_Click(object sender, EventArgs e)</p><p>`        `{</p><p>`            `NgayLe nl = new NgayLe(Convert.ToInt32(tbMaNL.Text), dtpkNL.Value, tbSuKien.Text);</p><p>`            `ngayLeDAO.Xoa(nl);</p><p>`            `tbSuKien.Text = "";</p><p>`            `tbMaNL.Text = "";</p><p>`            `dtpkNL.Value = DateTime.Today;</p><p>`            `dtgvNgayLe.DataSource = ngayLeDAO.LayDanhSach();</p><p>`        `}</p>|
| - |

Tìm kiếm trong bảng phân công

|<p>`        `private void tbTimKiem\_TextChanged(object sender, EventArgs e)</p><p>`        `{</p><p>`            `dtgvPhanCong.DataSource = pcDAO.TimKiem(tbTimKiem.Text);</p><p>`        `}</p>|
| - |

**5.6.2.5 Quản lý lương**

Người dùng có thể xem lương của từng nhân viên bằng cách chọn mã nhân viên trong Combobox MaNV hoặc có thể xem tất cả bằng cách bấm nút “Xem tất cả”. Còn thanh tổng lương ở phía dưới sẽ tính tổng lương của tất cả các bộ hiện lên trên datagridview của bảng TinhLuong.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.017.png)

Chọn nhân viên bằng combobox MaNV

|<p>`        `private void cbMaNV\_TextChanged(object sender, EventArgs e)</p><p>`        `{</p><p>`            `try</p><p>`            `{</p><p>`                `NhanVien nv = nhanVienDAO.LayThongTinNhanVienBangMaNV(cbMaNV.Text);</p><p>`                `if (nv != null)</p><p>`                `{</p><p>`                    `LoadThongTinNV(nv);</p><p>`                    `dtgvTinhLuong.DataSource = tinhLuongDAO.LayDanhSach(nv.MaNV);</p><p>`                `}</p><p>`                `else</p><p>`                    `throw new Exception();</p><p>`            `}</p><p>`            `catch</p><p>`            `{</p><p>`                `ResetThongTinNV();</p><p>`            `}</p><p>`        `}</p>|
| - |

**5.6.2.6 Quản lý doanh thu**

Lọc doanh thu từ ngày mấy đến ngày mấy. Thanh tổng doanh thu là tổng kết toàn bộ tổng tiền thanh toán thu được của cửa hàng. Thanh “Doanh thu lọc” là tính tổng tiền thanh toán của những hàng có hiện trên bảng doanh thu, còn thanh “Tiền lời lọc” là tính tổng tiền lời trên bảng doanh thu.

![](/images/Aspose.Words.b441b0ea-0d08-4d4a-9f2f-a13681ac0b8c.018.png)

Trang 76

