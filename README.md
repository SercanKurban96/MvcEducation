# ![image](https://github.com/user-attachments/assets/0ed8e467-f6ba-4d66-9994-1315245e1474)

👋 Merhabalar, oluşturmuş olduğum bu repo, Youtube'da Murat Yücedağ tarafından verilen 50 Derste MVC adlı eğitimde yapmış olduğum projeyi içermektedir.<br><br>

# 🖥️ MVC Ders 1 - Giriş

## ❗ MVC'ye Başlamadan Önce Bilinmesi Gereken Konular
✔️ C#<br>
✔️ ASP.NET<br>
✔️ SQL<br>
✔️ HTML - CSS - Bootstrap (Temel seviyede bilinmesi yeterlidir.)<br><br>

## ⚙️ MVC Nedir?
MVC (Model-View-Controller), yazılım geliştirmede kullanılan bir mimari desenidir. Uygulamayı üç temel bileşene ayırarak kodun daha düzenli, ölçeklenebilir ve yönetilebilir olmasını sağlar. Özellikle web uygulamalarında yaygın olarak kullanılır.<br><br>

### 🗒️ MVC Bileşenleri:
#### :one: Model (M - Veri Katmanı):

✅ Uygulamanın veri ve iş mantığını temsil eder.<br>
✅ Veritabanı işlemleri, iş kuralları ve veri yönetimi burada yapılır.<br>
✅ Örneğin, bir "Kullanıcı" modeli kullanıcı bilgilerini tutabilir ve veritabanı ile etkileşime girebilir.<br><br>

#### :two: View (V - Görünüm Katmanı):

✅ Kullanıcı arayüzünü temsil eder.<br>
✅ HTML, CSS, JavaScript gibi teknolojilerle sayfa gösterimini sağlar.<br>
✅ Modelden gelen veriyi kullanıcıya sunar.<br><br>

#### :three: Controller (C - Kontrolcü Katmanı):

✅ Kullanıcıdan gelen istekleri işler.<br>
✅ Model ile View arasındaki bağlantıyı kurar.<br>
✅ Kullanıcının yaptığı işlemlere göre uygun Model’i çağırır ve View’e gönderir.<br><br>

### 🧰 MVC Nasıl Çalışır?
:one: Kullanıcı bir istekte bulunur (örneğin bir web sayfasını ziyaret eder).<br>
:two: Controller, bu isteği alır ve ilgili Model ile iletişime geçer.<br>
:three: Model, gerekli verileri işler ve döndürür.<br>
:four: Controller, bu verileri uygun bir View içine koyar.<br>
:five: View, verileri işleyerek kullanıcıya gösterir.<br><br>

### 🎈 ASP.NET MVC Örneği
<b>Controller (KullanıcıController.cs)</b><br><br>

public class KullanıcıController : Controller<br>
{<br>
    public IActionResult Detay(int id)<br>
    {<br>
        Kullanıcı model = KullanıcıVeritabanı.Getir(id); // Modelden veri çek<br>
        return View(model); // View'e gönder<br>
    }<br>
}<br><br>

<b>Model (Kullanıcı.cs)</b><br><br>

public class Kullanıcı<br>
{<br>
    public int Id { get; set; }<br>
    public string Ad { get; set; }<br>
}<br><br>

<b>View (Detay.cshtml)</b><br><br>

#### <h2>@Model.Ad</h2><br><br>

✅ Bu yapı sayesinde veriyi işleme, görüntüleme ve kontrol etme işlemleri ayrıştırılmış olur. Bu da kodun daha düzenli ve yönetilebilir olmasını sağlar.<br><br>

<hr>

# 🖥️ MVC Ders 2 - View ve Layout Kavramları

![image](https://github.com/user-attachments/assets/08383b2e-6ddd-4ec4-b2fa-2b7c75de313a)
<br>
Visual Studio'dan yeni bir proje oluşturduktan sonra seçeceğimiz şablon <b>ASP.NET Web Application (.NET Framework)</b> olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/18109c95-945f-4d3b-b66a-425f2d963998)
<br>
Şablonumuzu seçtikten sonra karşımıza bu şekilde çıkacaktır. Projemizin ismini MvcProject olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3962574a-d9d0-43e1-9224-2f3ebabb65f3)
<br>
Ardından karşımıza bu şekilde çıkacaktır. Burada MVC projesi oluşturacağımız için MVC şablonu direkt seçili halde gelecektir. Create diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/fa8b11c3-faac-440a-9a25-0523262f0547)
<br>
Projemiz bu şekilde oluşturuldu.<br><br>

![image](https://github.com/user-attachments/assets/a04ef63d-b3c8-4a32-9998-41293b480af2)
<br>
MVC'de Views klasörüne geldiğimiz zaman karşımıza Home ve Shared isminde iki tane klasör bizi karşılamaktadır. ASP.NET MVC'de Views klasörü, uygulamanın kullanıcı arayüzünü oluşturan görünüm (View) dosyalarını içerir. Kullanıcıya sunulacak HTML içeriği burada bulunur.<br><br>

### 🗒️ Views Klasörünün İçeriği
Views klasörü içerisinde aşağıdaki yapılar bulunur:<br><br>

#### :one: Controller'a Özel Klasörler
✅ Her Controller için aynı isimde bir klasör bulunur.<br>
✅ Bu klasör içerisinde o Controller’a ait View dosyaları yer alır.<br>
✅ Örnek:<br><br>

Views<br>
├── Home<br>
│   ├── Index.cshtml<br>
│   ├── About.cshtml<br>
│   ├── Contact.cshtml<br>
├── Product<br>
│   ├── List.cshtml<br>
│   ├── Details.cshtml<br><br>

<b>HomeController</b> → Views/Home/ klasöründe bulunur.<br>
<b>ProductController</b> → Views/Product/ klasöründe bulunur.<br><br>

#### :two: Shared Klasörü
✅ Tüm Controller'lar tarafından ortak kullanılan View dosyaları burada yer alır.<br><br>
✅ Örnek:<br><br>

![image](https://github.com/user-attachments/assets/3277c84a-1fad-40e9-ba78-7d275159fe4c)
<br>
<b>_Layout.cshtml</b> → Tüm sayfalar için ortak bir şablon (Header, Footer gibi öğeler içerir).<br>
<b>_ViewStart.cshtml</b> → Sayfa başlatma işlemleri için kullanılır.<br>
<b>_ViewImports.cshtml</b> → Genel @using ve @addTagHelper gibi direktifleri içerir.<br>
<b>Error.cshtml</b> → Hata sayfası.<br><br>

Örnek Shared klasör yapısı:<br><br>
Views<br>
├── Shared<br>
│   ├── _Layout.cshtml<br>
│   ├── _ViewStart.cshtml<br>
│   ├── _ViewImports.cshtml<br>
│   ├── Error.cshtml<br><br>

#### :three: _ViewStart.cshtml
✅ <b>Tüm View dosyaları için varsayılan ayarları belirler.</b><br>
✅ Genellikle ortak bir Layout dosyasını belirtmek için kullanılır.<br><br>

@{<br>
    Layout = "~/Views/Shared/_Layout.cshtml";<br>
}<br><br>

#### :four: _ViewImports.cshtml
✅ Proje genelinde kullanılacak olan isim alanlarını (namespace) ve Tag Helper'ları içerir.<br>
✅ Örneğin: <br><br>

@using ProjeAdi.Models<br>
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers<br><br>

#### :five: _Layout.cshtml
✅ Ortak şablon yapısıdır.<br>
✅ @RenderBody() ile her sayfanın değişen içeriği buraya yerleştirilir.<br><br>

#### 🧰 Özetle
📌 Views klasörü kullanıcıya gösterilecek HTML içeriğini barındırır.<br>
📌 Her Controller için bir klasör bulunur ve o Controller'a ait View'ler burada saklanır.<br>
📌 Shared klasörü, ortak View dosyalarını içerir (örneğin _Layout.cshtml).<br>
📌 _ViewStart.cshtml, varsayılan ayarları belirler.<br>
📌 _ViewImports.cshtml, global isim alanlarını ve Tag Helper'ları ekler.<br><br>

![image](https://github.com/user-attachments/assets/54c550c8-a2e1-4db2-a684-c8df9f985585)
<br>
Home klasöründe yer alan Index sayfasına gidelim ve sağ tıklayarak View in Browser diyelim.<br><br>

![image](https://github.com/user-attachments/assets/d63ae386-9775-4972-b787-754022a68b95)
<br>
Sayfamızı çalıştırdığımız zaman karşımıza bu şekilde çıkacaktır.<br><br>

![image](https://github.com/user-attachments/assets/afe6b259-21e1-4744-9c6e-b9c86c86a9d0)
<br>
Bu kez Shared klasöründe yer alan _Layout sayfasına gidip RenderBody'nin üstüne örnek olarak Merhaba yazalım, ancak çalıştırırken Layout üzerinden değil tekrardan Index üzerinden çalıştırıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a220ffe8-3673-414d-aa51-ad716549a61f)
<br>
Merhaba yazısı bizi karşılamış oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 3 - Controller Yapısı ve Layout Düzenlemeleri

![image](https://github.com/user-attachments/assets/ab9bf4d3-8790-4e22-aa64-eed2a433c748)
<br>
İlk olarak Index sayfasından çalıştırdığımız zaman üstte yer alan Home, About, Contact gibi alanlar yer almaktadır. Buradaki alanlara erişmek, düzenleme yapmak için Layout.cshtml sayfasından ayarlıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3609e4f1-4dc0-4011-8a3a-8d5889bead13)
<br>
Layout.cshtml sayfasına geldiğimiz zaman bize burada Application name ile birlikte dört tane alan karşılayacaktır.<br>
@Html.ActionLink dediğimiz şey, Web Form'daki LinkLabel gibi düşünebilirsiniz. Bir alana link verip oradan yönlendirme işlemi yapmak için kullanacağımız alanı temsil eder.<br>
✔️ Üç tane parametresi bulunmaktadır.<br><br>
<b>Birincisi:</b> Menünün içerisinde ne yazacağını belirtir.<br>
<b>İkincisi:</b> Bunun ActionResult tarafındaki değerini belirtir. Örneğin Home kısmı Index'e gidecektir.<br>
<b>Üçüncüsü:</b>  Object Route Value olarak geçen bu değer parametre taşımak için kullanılır.<br><br>

Buradan Controller dosyasına gidelim.<br><br>

![image](https://github.com/user-attachments/assets/bb7c1ee5-a9d3-42c9-ac6b-1b43b01e2db4)
<br>
Controllers klasörüne baktığımız zaman bize bir tane HomeController isminde hazır olarak verilmiştir. Buraya tıklayalım.<br><br>

![image](https://github.com/user-attachments/assets/757890ca-dd8d-4e9f-9d21-af87bc23f1c1)
<br>
HomeController bu şekilde karşımıza çıkacaktır. Burada arka planda çalışan, işin Controller tarafında çalışan metotlarımızı tutan alandır. HomeController içerisinde Index, About ve Contact isminde üç tane ActionResult alanları bulunmaktadır.<br>
Burada Layout.cshtml sayfasına gidip örnek bir menü ekleyelim.<br><br>

![image](https://github.com/user-attachments/assets/c979412c-84bd-4872-aa41-3905e1d33694)
<br>
Burada ilk parametrede yer alan 4 Nolu Sütun, sayfamızın görünen kısmı olacaktır. Buraya tıkladığımızda bizi About sayfasına yönlendirecektir.<br><br>

![image](https://github.com/user-attachments/assets/d02c5fd7-1523-4f6b-8055-6f3f0b137dbe)
<br>
Oluşturduğumuz yeni sayfa burada görüntülenmiş oldu. Sayfamıza tıklayalım.<br><br>

![image](https://github.com/user-attachments/assets/02e8bdd7-63c5-4631-99ba-3a2b3eea46cb)
<br>
Karşımıza bu şekilde bir mesaj çıkacaktır. Peki biz bu içeriği değiştirebilir miyiz ona bakalım.<br><br>

![image](https://github.com/user-attachments/assets/3df89f41-117a-4238-9ad0-e001b92a6360)
<br>
Views klasöründen Home klasörüne ait olan About.cshtml sayfasına gittiğimiz zaman bu şekilde karşımıza çıkacaktır. Buradan istediğiniz yazıyı yazabilirsiniz.<br><br>

![image](https://github.com/user-attachments/assets/057a85f9-8be7-460a-b2cf-363b93c5745e)
<br>
Burada birkaç metin değişikliği yaptık. Programımızı çalıştıralım.<br><br>

![image](https://github.com/user-attachments/assets/a8c6cc9e-a7d0-4f84-bbdd-0bda2ed36c0b)
<br>
Yazdığımız mesaj bu şekilde karşımıza çıktı. Yazdığımız mesajın yukarısında yer alan Your application description page mesajı HomeController'in About kısmında yer almaktadır.<br><br>

![image](https://github.com/user-attachments/assets/4df9d471-4543-4334-9f32-a3400bae9334)
<br>
Buradaki yazıyı değiştirmiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/5e6593ce-0626-4687-8384-b79dd3182006)
<br>
Sayfayı tekrardan çalıştırdığımızda yazdığımız mesaj burada görüntülenmiş oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 4 - Controller Yapısı ve Layout Düzenlemeleri

![image](https://github.com/user-attachments/assets/119fbbdd-445f-43ee-88b6-1640580d9668)
<br>
HomeController'da Index, About ve Contact isminde üç tane alanımız bulunmaktaydı. Burada yeni bir tane alan tanımlıyoruz ve ismini Bilgi olarak belirledik. Bunun sonucunda bize direkt View olarak döndürmesini sağlıyoruz.<br><br>

### ⚠️ <b>View oluşturmak için uygulanacak adımlar:</b>

![image](https://github.com/user-attachments/assets/8d006ac0-9c14-4a91-843b-8c1da426281a)
<br>
Oluşturduğumuz ActionResult'tan Bilgi ismini verdiğimiz alana sağ tıklayıp "Add View" diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/39be728e-293b-4897-8b7a-e2e9f134acd0)
<br>
Karşımıza bu şekilde çıkacaktır. Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0dd1539e-5df0-4293-b923-16193d89a4c5)
<br>
View ekleme alanı bu şekilde karşımıza çıkacaktır. Burada Use Layout Page kısmı seçili olarak gelecektir. Oluşturacağımız View'a Layout eklemek için sağında bulunan ... işaretine tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/54a1e9e7-1947-4ed5-a669-fbf0506b6f3b)
<br>
Karşımıza bu şekilde çıkacaktır.<br><br>

![image](https://github.com/user-attachments/assets/05e62f4c-6ecd-4e6c-b6c6-345306ab37c6)
<br>
Burada Layout seçebilmek için Views klasörüne geliyoruz ve hemen ardından Shared klasörüne tıklıyoruz. Shared klasörüne tıkladıktan sonra iki tane sayfa karşımıza çıkacaktır. Burada Layout ekleyeceğimiz için _Layout.cshtml sayfasını seçiyoruz ve OK diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/099bf4e2-3cd0-4b85-8021-c6d73a3ee806)
<br>
Layout sayfamız hazır. Add diyoruz ve biraz bekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7c230361-67ea-4b97-8b49-f7d986c5badc)
<br>
Bilgi sayfası bu şekilde gelmiş oldu.<br><br>

![image](https://github.com/user-attachments/assets/f39b5fa5-9c8d-461b-89d4-b83b4d1300a8)
<br>
Layout.cshtml sayfasına gidip oluşturduğumuz Bilgi sayfasına ait yeni bir alan ekleyelim.<br><br>

![image](https://github.com/user-attachments/assets/4313ef50-a53c-4917-a6b2-866151a0ce9e)
<br>
Bilgi sekmesi karşımıza bu şekilde çıkmış oldu.<br><br>

<hr>

# 🖥️ MVC Ders 5 - Statik Web Projesi ~ 1

Tema Linki: https://disk.yandex.com.tr/d/UPFpSA0fMGODIw <br><br>

![image](https://github.com/user-attachments/assets/f0012f2a-fc1a-44cb-a35e-820169faf494)
<br>
Kullanacağımız şablon bu şekilde olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/7587c0d9-536f-44d7-9840-993306060d40)
<br>
Yeni bir MVC projesi oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/b86c8e96-ec0d-4282-87e9-8274c2252f09)
<br>
Projeyi oluşturduktan sonra linkteki dosyaları çıkartıyoruz. Çıkartılan web klasörünü tutup katmanımıza sürüklüyoruz.<br><br>

![image](https://github.com/user-attachments/assets/725edf5b-8da4-4004-8ca2-da32556abc8a)
<br>
Ardından yeni bir Controller oluşturuyoruz. Burada varsayılan isim DefaultController olarak çıkacaktır. Burada istediğiniz ismi verebilirsiniz.<br><br>

![image](https://github.com/user-attachments/assets/179d0ffa-6d41-4eeb-b6d5-67e3c464221e)
<br>
Index'e sağ tıklayıp Add View diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d0a5da66-230d-48dc-b1f8-881d5d0c46de)
<br>
Burada herhangi bir Layout kullanmıyoruz, çünkü burası bizim direkt Layout sayfamız olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/e2c065f3-ad01-48bb-9f18-ab1a24efce0d)
<br>
İndirdiğimiz web klasörüne gelip index.html sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8ca1d2c3-aeb4-43f6-b31c-4b32776097fd)
<br>
Buradaki bütün alanları kopyalayıp oluşturduğumuz Index'e ait olan view'e yapıştırıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/738676f6-dc15-4730-bcaf-59e2bd0e95e6)
<br>
Index sayfamızdaki tüm kodları bu şekilde yapıştırıyoruz. En üstte yer alan Layout = null kısmına dokunmuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/101ca799-cd55-43a5-a849-c2f99e8abebd)
<br>
Projeyi çalıştırdıktan sonra şablondaki görüntüler gelmeyecektir. Bunun nedeni CSS yolunu görememektedir. Şimdi CSS yollarını belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/df5d421c-5069-4c28-a8cd-b464248d4393)
<br>
Burada çıkartılan klasörün ismi hangisiyse onu yazıyoruz. İlk olarak başına ~ (ALT GR + Ü) işaretini koyuyoruz ve ardından / (SHIFT + 7) işaretini koyuyoruz. Ardından klasörümüzün ismi hangisiyse onu yazıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e194ecd8-efa7-40be-af4a-40d782d73821)
<br>
Aynı şekilde img gördüğünüz dosyaları da bu şekilde uyguluyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7a76ed8c-323a-4d62-89ca-fb85769fd685)
<br>
Script dosyalarına da aynısını uyguluyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a280ee1e-93cb-4f9d-9395-bce607e3162f)
<br>

![image](https://github.com/user-attachments/assets/33c6036a-5322-4e02-9de3-dd2045bbab12)
<br><br>

<hr>

# 🖥️ MVC Ders 6 - Statik Web Projesi ~ 2

Bu bölümde herhangi bir veri tabanı kullanmadan statik olarak alanlarımızı değiştirdik.<br><br>

![image](https://github.com/user-attachments/assets/5d325a80-1dc7-4b11-b555-d7fea805ff20)
<br>

![image](https://github.com/user-attachments/assets/13995e2b-fb2c-4ea2-a68f-128b11b48dfd)
<br><br>

<hr>

# 🖥️ Mvc Ders 7 - Ürün Stok Projesi Db ve Tablo Oluşturma
Bu bölümde yeni bir veri tabanı oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/241747b4-f16e-4b2f-bbe6-8a1bf55458cf)
<br>
Veri tabanımızı oluşturduk. Şimdi tablolarımızı oluşturalım.<br><br>

![image](https://github.com/user-attachments/assets/783904a5-3394-4489-82bf-bda4bab0bad3)
<br>

![image](https://github.com/user-attachments/assets/592be3bd-2b5b-4f12-bfce-5a717db365b1)
<br>

![image](https://github.com/user-attachments/assets/9b1c6f20-b462-416e-8e52-f430930bab3e)
<br>

![image](https://github.com/user-attachments/assets/eca2b5cd-018f-4004-8820-2d583d6e77d3)
<br>
Tablolarımızı bu şekilde oluşturduk.<br><br>

<hr>

# 🖥️ Mvc Ders 8 - Diyagram Ve İlişkiler

![image](https://github.com/user-attachments/assets/941d48c7-6663-4e09-9b07-3d6a8f39445e)
<br>
Yeni bir diyagram oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3d9fb5c3-f0a7-4cae-ae2e-ccccc331f817)
<br>
İlişkili Diyagramlar bu şekilde olacaktır;<br>
TBLKATEGORILER ~ KATEGORIID --> TBLURUNLER ~ URUNKATEGORI<br>
TBLURUNLER ~ URUNID --> TBLSATISLAR ~ URUN<br>
TBLMUSTERILER ~ MUSTERIID --> TBLSATISLAR ~ MUSTERI<br><br>

<hr>

# 🖥️ Mvc Ders 9 - Örnek Veri Girişleri

![image](https://github.com/user-attachments/assets/bd73eae2-05f4-4fda-bad7-a0c52beb22f1)
<br>

![image](https://github.com/user-attachments/assets/044c51e0-8686-4be8-96c9-d36d66bd29eb)
<br>
TBLURUNLER tablosunda küçük bir değişiklik yaptık. Burada MARKA ve STOK isminde iki sütun ekledik.<br><br>

![image](https://github.com/user-attachments/assets/363b580e-3f32-4350-80a0-a9543905d8c9)
<br>

![image](https://github.com/user-attachments/assets/cc390f9a-9715-4535-bb2f-1913aac59a68)
<br><br>

<hr>

# 🖥️ Mvc Ders 10 - Modelin Oluşturulması

![image](https://github.com/user-attachments/assets/acfb4a67-3a1d-4683-bd98-e7fad48c7fa0)
<br>
Yeni bir proje oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/57b9aa86-020d-4b66-a7d7-c5b3b0d6afef)
<br>
Models klasörüne sağ tıklayıp Entity isminde yeni bir klasör oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d71cb1b2-a88b-478d-95de-d95841eed4f0)
<br>
Entity klasörüne sağ tıklayıp Add kısmından New Item diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d177ecea-aa5a-4f19-b0db-7aa946c9179f)
<br>
Sol tarafta yer alan Data seçeneğini seçip ADO.NET Entity Data Model diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0c05543a-17f4-48f2-b7c5-7e1cb89dd874)
<br>
Next diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d5713e7e-6461-496c-9289-52cb0f6983b8)
<br>
Veri tabanımızı seçiyoruz ve OK diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8dc6a3d5-6e3c-40f7-9c34-7c5a5b9bef0c)
<br>
Next diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/767134d1-c930-4dda-a277-80b9fce4a679)
<br>
Tablodaki bütün alanları seçtikten sonra Finish diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/cd1e0e19-e38b-4ea7-97a6-54515fcda9af)
<br>
Modelimiz oluşturuldu.<br><br>

<hr>

# 🖥️ Mvc Ders 11 - Controller Ve Navbar

Burada Bootstrap Navbar isminde arama yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/61838ba9-fd20-408d-892c-fc6fe705c0a8)
<br>
Burada istediğiniz Navbar kullanabilirsiniz. Burada Inverted Navbar olanı kullanacağız. Try it Yourself diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5e7208a9-b285-43cc-be6c-627977a0f695)
<br>
Buradaki alanların tümünü kopyalıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7c6e561b-db6b-41ad-8505-e0c90d001f81)
<br>
Shared klasörüne sağ tıklayıp Add kısmından View diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d9704d40-0210-413f-9496-8f597ece9fce)
<br>
İsmini _MainLayout olarak belirliyoruz ve herhangi bir Layout sayfası kullanmıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/90f77888-fb70-4a4f-9e60-a6a4d37a17d9)
<br>
Kopyaladığımız Navbar kodlarını oluşturduğumuz _MainLayout içerisine yapıştırıyoruz.<br><br>

Controller işlemlerine geçiyoruz. Bunun için Controllers klasörüne gelip yeni bir Controller oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3d31ca67-fea7-445c-8083-228e296329e4)
<br>
İsmini KategoriController olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/8108c150-1e3f-429d-b154-c2dd0b791201)
<br>
KategoriController oluşturduktan sonra Index'e sağ tıklayıp yeni bir View oluşturuyoruz ve burada _MainLayout sayfasını kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/30864909-d001-465e-b7b1-790656cd7630)
<br>
Index oluşturuldu. Çalıştırmayı deneyelim.<br><br>

![image](https://github.com/user-attachments/assets/4608d477-c31c-4f17-935a-42d26aa3ba1e)
<br>
Karşımıza böyle bir hata çıkmaktadır. Bunun sebebi RenderBody metodu herhangi bir yere çağırılmadı.<br><br>

### 🧰 RenderBody Nedir?
RenderBody, ASP.NET MVC ve ASP.NET Core MVC projelerinde Layout (Düzen) sayfası içerisinde kullanılan bir yöntemdir.<br>
RenderBody(), Layout (Master) sayfasında belirlenen bir alana, her bir sayfanın (View'in) içeriğini yerleştirmek için kullanılan bir metottur.<br>
Bir Layout sayfasında genellikle şunlar bulunur:<br><br>

💠 Sabit içerikler (Header, Footer, Menü vb.)<br>
💠 Dinamik olarak değişen içerik alanı (RenderBody() burada devreye girer.)<br><br>

![image](https://github.com/user-attachments/assets/b1a10df3-5c9b-434e-930c-5ded2f8aedc6)
<br>
_MainLayout sayfasına gittiğimiz zaman container class'ta yer alan bazı metinler bulunmaktadır. Layout işlemlerini burada çağıracağımız için RenderBody() metodunu buraya ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/625d7636-75f1-4107-ae4e-92c96864bff3)
<br>
RenderBody metodunu buraya eklemiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/9eea0a10-24fa-40ec-9dda-d19a8f4d1d88)
<br>
Tekrardan Index üzerinden çalıştırdığımız zaman karşımıza bu şekilde çıkmış oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 12 - Menüyü Türkçeleştirme

![image](https://github.com/user-attachments/assets/61053c10-df4e-46c3-ba13-27182a88271d)
<br>

![image](https://github.com/user-attachments/assets/2b4c8426-095e-41a6-a9e3-4be0c0aeb264)
<br><br>

<hr>

# 🖥️ Mvc Ders 13 - Kategorileri Listeleme

![image](https://github.com/user-attachments/assets/44efbcf5-8bd1-4942-a89a-c740aa035e2b)
<br>
İlk olarak using kütüphanesinde tanımladığımız modeli buraya ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/6cce3330-d428-4b75-9fb1-4013972ae55d)
<br>
Ardından oluşturduğumuz modeli buraya ekliyoruz ve ismini db olarak belirliyoruz. Listelemek için var türünden degerler isminde bir değişken oluşturup TBLKATEGORILER tablosundan ToList metoduyla listeleme işlemini yaptık. Ardından return View içerisine degerler değişkenini eklemiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/0eb41cd8-ff0e-4c84-8303-12850d7f6ad6)
<br>
Index sayfasına gidiyoruz. Burada tanımlamamız gereken iki tane komut var. Bunlardan birincisi @using MvcStok.Models.Entity, ikincisi ise bizim bir modele ihtiyacımız olacaktır. Kullanacağımız komut ise @model List<TBLKATEGORILER> olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/45c418c3-6621-4e33-ad0d-57e2ce51dbe1)
<br>
Burada listeleme işleminde verilerimizin düzgün bir şekilde gözükmesi için bir tane tablo oluşturduk. Tablo oluşturmak için HTML etiketlerinden table olanı kullandık. Burada tablonun kenarlıklarını belirlemek için table table-bordered kullandık. Ardından satır oluşturmak için tr etiketini, tabloya ait başlık belirtmek için th kullandık. Başlıkları belirledikten sonra verileri göstermek için ilk önce tbody etiketini, ardından @foreach komutunu kullandık. Burada ktgr isminde bir değişken oluşturup Model içerisinden verileri almış olduk. TBLKATEGORILER tablosunda iki tane sütunları buraya eklemiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/d877a946-dbf0-4bdc-a8ae-ce4687c4271c)
<br>
Çalıştırdığımız zaman TBLKATEGORILER tablosuna ait veriler bu şekilde listelenmiş oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 14 - Ürünleri Listeleme

KategoriController'da yaptığımız gibi aynı işlemleri bu kez TBLURUNLER için yapıyoruz. Bu kez UrunController oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/cd0b93a3-833e-4ae4-9cc8-f89c9fe02a27)
<br>

![image](https://github.com/user-attachments/assets/549cb996-f161-4e16-9928-fe19e753cc51)
<br>

![image](https://github.com/user-attachments/assets/3c6d3102-97f6-46d6-a4e3-2f08e06283d2)
<br>
Burada KATEGORI sütununda isimler yerine ID değerlerini göstermektedir. İlerleyen zamanlarda bu kısmı değiştiriyor olacağız.<br><br>

<hr>

# 🖥️ Mvc Ders 15 - Müşteri Listeleme

MusteriController<br><br>

![image](https://github.com/user-attachments/assets/718ee9dd-fe4d-432c-9735-60dd34544c73)
<br>

![image](https://github.com/user-attachments/assets/abb9d2d6-0691-4102-b2e7-3fdeaf6cc81f)
<br>

![image](https://github.com/user-attachments/assets/d81f84b3-f06f-4df9-9305-1159c0cbb101)
<br><br>

MusteriController listeleme işlemi tamamlandıktan sonra _MainLayout'a gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7dbeab9b-0d93-4d4b-8a69-dcf68c47d391)
<br>
Burada menüde yer alan başlıklara tek tek bağlantı adreslerini vermiş olduk.<br><br>

<hr>

# 🖥️ Mvc Ders 16 - Silme Ve Güncelleme Alanlarının Oluşturulması

![image](https://github.com/user-attachments/assets/a59f0093-857c-4e55-8e46-7bf965823ca0)
<br>
Burada Kategoriye ait olan Index sayfasına gelip SİL ve GÜNCELLE isminde iki tane daha sütun ekliyoruz.<br>
Burada ID ve AD değerlerini ekranda gösterdikten sonra bu kez silme ve güncelleme işlemlerini oluşturuyoruz. Burada a etiketini kullanarak ID'ye göre bağlantı vermiş olduk. İlerleyen zamanlarda KategoriController'a ait silme ve güncelleme oluşturacağız. Burada görünümü daha düzgün olsun diye butonlara class ekledik. En altta yer alan link ise yeni bir kategori ekleme işlemini gerçekleştirecektir. Aynı işlemleri ürünler ve müşteriler için de yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c487ea06-241a-43d2-8409-bedcf517392b)
<br>
Görünümü bu şekildedir.<br><br>

<hr>

# 🖥️ Mvc Ders 17 - HttpGet ve HttpPost
