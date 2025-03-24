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
Bilgi sayfası bu şekilde gelmiş oldu. Controller üzerinden Bilgi sayfasını görüntüleyebilmek için ActionResult kısmından Bilgi ismine sağ tıklayıp Go To View diyoruz.<br><br>

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

## 🧰 HttpGet ve HttpPost Nedir?
HttpGet ve HttpPost, HTTP protokolünde kullanılan iki temel isteğin (request) türüdür. Web uygulamalarında özellikle ASP.NET Core, MVC ve Web API gibi çerçevelerde sıkça kullanılırlar.<br><br>

### 1. HttpGet Nedir?
💠 GET isteği, sunucudan veri almak için kullanılır.<br>
💠 URL ile birlikte sorgu parametreleri (query string) gönderir.<br>
💠 Idempotenttir, yani aynı GET isteği tekrar tekrar yapıldığında sunucunun durumu değişmez.<br>
💠 Güvenli (safe) kabul edilir, çünkü sunucuda veri değiştirmez.<br>
💠 Önbelleğe alınabilir (cacheable), bu nedenle tarayıcı tarafından saklanabilir.<br>
💠 Veri boyutu kısıtlıdır, URL içinde parametreler taşındığı için uzun URL’ler sorun yaratabilir.<br><br>

### 2. HttpPost Nedir?
💠 POST isteği, sunucuya veri göndermek ve yeni kayıt oluşturmak için kullanılır.<br>
💠 İstek gövdesinde (body) veri taşır, bu nedenle büyük veri gönderimine uygundur.<br>
💠 İdempotent değildir, yani aynı POST isteği tekrar yapıldığında her seferinde yeni bir veri kaydı oluşabilir.<br>
💠 Önbelleğe alınmaz, çünkü her isteğin sonucu değişebilir.<br><br>

### 🗒️ Ne Zaman Kullanılmalı?
✅ <b>HttpGet Kullanılmalı:</b><br>
💠 Veritabanından veri almak için.<br>
💠 Sayfalama veya filtreleme işlemleri için.<br>
💠 Önbellek desteğinden yararlanılacak durumlarda.<br><br>

✅ <b>HttpPost Kullanılmalı:</b><br>
Form verisi veya JSON gibi büyük veri göndermek için.<br>
Kullanıcı kaydı, sipariş oluşturma gibi işlemlerde.<br>
Güvenlik açısından hassas verilerin işlenmesi gerektiğinde.<br><br>

![image](https://github.com/user-attachments/assets/8f61b8cd-5706-4c59-9e51-fc536814560b)
<br>
YeniKategori isminde bir metot tanımlayıp View oluşturuyoruz. Kategori ekleme işlemi için HttpGet ve HttpPost metotlarını kullanıyoruz. HttpGet işleminde direkt return View yaparken, HttpPost işleminde ise önce TBLKATEGORILER tablosundan bir tane p1 değişkeni oluşturup ardından Add komutunu kullanarak p1 değerini ekliyoruz. Değişiklikleri kaydetmek için SaveChanges kullanıyoruz.<br><br>

<hr>

# 🖥️ Mvc Ders 18 - Kategori Ekleme

![image](https://github.com/user-attachments/assets/05a12996-d375-4ecb-b6c8-adb0623e23b9)
<br>
YeniKategori sayfasına geliyoruz ve ilk olarak bir form etiketi oluşturuyoruz. Ardından method kısmında ekleme işlemi yaptığımız için post kullanıyoruz.<br>
Ardından div etiketiyle ayırma işlemi yapıyoruz. Burada etiket adını Kategori Adı olarak belirliyoruz. Veri girişi için input etiketini kullanıp text olarak belirliyoruz. Metin kutusu görünümünü düzgün bir şekilde göstermek için class form-control olarak kullanıyoruz ve name kısmında ise veri tabanımızda yer alan sütunun ismini yazıyoruz.<br>
Ardından bir daha div oluşturup bu kez buton oluşturuyoruz ve ekleme işlemini gerçekleştiriyoruz.<br><br>

![image](https://github.com/user-attachments/assets/187e80bc-fcee-4422-80e5-b528c924fe96)
<br>

![image](https://github.com/user-attachments/assets/9c535942-d460-4e02-9a40-207f0d570ef5)
<br>

![image](https://github.com/user-attachments/assets/c982db84-ff52-46ff-8bea-b838f41df1ec)
<br><br>

<hr>

# 🖥️ Mvc Ders 19 - Müşteri Ekleme

![image](https://github.com/user-attachments/assets/a7d66742-1b59-4d61-874f-b7d414d7de84)
<br>

![image](https://github.com/user-attachments/assets/f0869f4b-fb71-477f-aac3-43562f76aca8)
<br>

![image](https://github.com/user-attachments/assets/488cf1c4-140e-4cb9-b06d-dc8dd511853d)
<br>

![image](https://github.com/user-attachments/assets/a7569eda-e37d-4590-b864-4750e1fa3074)
<br><br>

<hr>

# 🖥️ Mvc Ders 20 - Yeni Ürün Ekleme Sayfa Tasarımı

![image](https://github.com/user-attachments/assets/f723201d-a8b3-41d0-967f-21ed494a9c10)
<br>

![image](https://github.com/user-attachments/assets/e7d92832-d2e1-4f96-8116-bc0decb23d0b)
<br>

![image](https://github.com/user-attachments/assets/fda9ec96-e326-4f55-8c5a-6549dada9aea)
<br>

![image](https://github.com/user-attachments/assets/71142269-12e6-4845-9a88-8826cc714f5f)
<br>
Burada ürün ekleme işlemi yaparken Kategori Seçiniz kısmında bize kategori isimleri gelmemektedir. Bunun yerine ilk olarak kategoriye ait olan ID değerini elle yazdık. Ancak bu kullanım pek doğru değildir. Bunun için Kategori Seçiniz kısmını text yerine DropDownList işlemini yapacağız.<br><br>

![image](https://github.com/user-attachments/assets/773a25bf-9f8d-4fda-a9e1-67a9bf1e4c14)
<br><br>

<hr>

# 🖥️ Mvc Ders 21 - Dropdownlist Kullanımı

![image](https://github.com/user-attachments/assets/e9ee327c-9640-4ca9-a06d-c6aff5493765)
<br>
Örnek olarak herhangi bir siteden dropdownlist kullanımı ile ilgili kodları kopyalayıp Home klasöründe yer alan About sayfasında deneyelim.<br><br>

![image](https://github.com/user-attachments/assets/4fcfa937-3f0a-4570-8e3b-fb0e7f30e7cf)
<br>

![image](https://github.com/user-attachments/assets/88f0eb0c-df90-41e0-858e-81e05823b137)
<br>

![image](https://github.com/user-attachments/assets/e440967c-72fb-4f93-9ac0-7668b3dcdb17)
<br>
Dropdownlist manuel kullanımı bu şekildedir.<br><br>

<hr>

# 🖥️ Mvc Ders 22 - DropDownList DB den Veri Çekme

UrunController'a geliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4a28de89-9eb9-442a-82ce-e332457a99f3)
<br>
Burada ilk olarak List belirliyoruz ve <> içerisine SelectListItem olarak tanımladıktan sonra degerler isminde bir değişken oluşturuyoruz.<br>
Ardından LINQ sorgusu oluşturuyoruz. Oluştururken from dedikten sonra i isminde bir değişken tanımlıyoruz ve TBLKATEGORILER verilerine ait listeleri görüntülüyoruz.<br>
Ardından select new SelectListItem diyerek {} işaretiyle ID ve AD değerlerini giriyoruz.<br>
Burada Text değeri kategoriye ait adını, Value değeri ise kategoriye ait ID değerini gösterir. Değerleri yazdıktan sonra ToList metodunu ekliyoruz.<br>
En sonda ViewBag ile taşıma işlemini yapıyoruz. Burada YeniUrun sayfasına ait olan Kategori Seçiniz kısmında text yerine Dropdownlist kullanacağız. ViewBag işlemini buraya taşıyor olacağız.<br><br>

### LINQ Nedir?
LINQ (Language Integrated Query), .NET platformunda veri kaynaklarına (koleksiyonlar, SQL veritabanları, XML dosyaları vb.) sorgu yapmayı sağlayan, C# ve VB.NET dillerine entegre edilmiş bir sorgulama dilidir. LINQ sayesinde SQL benzeri ifadelerle veri üzerinde sorgular ve işlemler gerçekleştirilebilir.<br><br>

![image](https://github.com/user-attachments/assets/4092ca18-c56a-4837-bfed-ba8a473da9b9)
<br>
YeniUrun sayfasına geldikten sonra en üst tarafa bir tane model oluşturmamız gerekecektir. Buradaki model ürünlere ait olan Kategorileri eklemek için kullandık.<br>
Kategori Seçiniz kısmına geldiğimizde text kısmını kaldırıp yerine @Html.DropDownListFor kullandıktan sonra burada LINQ üzerinden m türünde bir değişken belirledik ve burada KATEGORIAD değerlerini gösterdik.<br>
Ardından List türünden SelectListItem olarak belirleyip ViewBag ile taşıma işlemini yapmış olduk. Buradaki yazdığımız dgr değerini aynısını buraya ekliyoruz.<br>
Ardından formumuzun görüntüsünü bozmamak için class türünden form-control kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/114d0ec9-fd3e-484b-b419-773735b21448)
<br>
Kategori Seçiniz kısmındaki veriler gelmiş oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 23 - Yeni Ürün Ekleme

![image](https://github.com/user-attachments/assets/d5c24366-f6a4-4392-85f4-33d47b0f7152)
<br>
Burada yeni bir ürün ekleme işlemi gerçekleştirmek için kategoriyi dropdown'dan seçip ekleyeceğiz. LINQ üzerinden gidiyoruz.<br>
Var türünden ktg isminde bir değişken oluşturup TBLKATEGORILER tablosundan Where şartını yazıyoruz.<br>
LINQ sorgusundan m isminde bir değişken oluşturup KATEGORIID değeri ile TBLKATEGORILER tablosundaki KATEGORIID değerine eşitlemeye çalıştıktan sonra FirstOrDefault metodunu kullanıyoruz.<br>
Ardından p1.TBLKATEGORILER değerini ktg değerine atıyoruz.<br>
En sonda yer alan return View yerine return RedirectToAction kullanıyoruz. RedirectToAction içerisindeki Index ise kaydetme işlemi gerçekleştikten sonra direkt Index sayfasına atayacaktır.<br><br>

![image](https://github.com/user-attachments/assets/e62f8b8a-7634-438f-804b-5d6d7bde75e3)
<br>
Burada küçük bir değişiklik yapıyoruz. En üstte yer alan Models.Entity'den sonra TBLURUNLER, Dropdownlist kısmında ise TBLKATEGORILER.KATEGORIID olarak değiştiriyoruz.<br><br>

<hr>

# 🖥️ Mvc Ders 24 - ID'ye göre Kategori Adı Getirme

UrunController'a ait Index sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9173e2ef-5175-4dd5-9cc8-0d6728439ca0)
<br>
Burada yapacağımız tek değişiklik URUNKATEGORI yerine TBLKATEGORILER.KATEGORIAD ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5be0d2a4-186d-4610-8161-15ef21b8a028)
<br><br>

<hr>

# 🖥️ Mvc Ders 25 - Kategori Silme

![image](https://github.com/user-attachments/assets/fbdd3ca5-7790-4ea2-ab53-c5972b9f6f43)
<br>
Silme işlemi ID değere göre yapılmaktadır. Burada kategori isminde bir değişken tanımlayıp ID değerini bulmak için Find metodunu tanımlıyoruz.<br>
Ardından bulunan değeri silmek için Remove metodunu uyguluyoruz ve değişiklikleri kaydediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a528196a-d55a-4276-be9b-5d9b2500d66a)
<br>
Buradan Banyo Aletleri kategorisini silelim.<br><br>

![image](https://github.com/user-attachments/assets/a7c4f2ad-a050-4d17-8662-402e995437af)
<br><br>

<hr>

# 🖥️ Mvc Ders 26 - Ürün Silme

![image](https://github.com/user-attachments/assets/a7ab509e-13e7-4695-9740-80c37fce9843)
<br>

![image](https://github.com/user-attachments/assets/69e53019-cf28-4c24-954a-ad2f78e980e6)
<br>
Buradan Mikrodalga ürününü silelim.<br><br>

![image](https://github.com/user-attachments/assets/11dddddb-7af0-412e-88d6-b38efa76c052)
<br><br>

<hr>

# 🖥️ Mvc Ders 27 - Müşteri Silme

![image](https://github.com/user-attachments/assets/1a1f362b-9458-4285-ae36-21651780e58f)
<br><br>

<hr>

# 🖥️ Mvc Ders 28 - Sayfalar Arası Veri Taşıma Kategori

![image](https://github.com/user-attachments/assets/322100c3-46bf-470a-8b58-d8f3d741d784)
<br>
Kategori getirme işlemini ID'ye göre getiriyoruz. Ardından bir View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7824f611-35e4-4744-adda-dce47fdfcba9)
<br>
Kategoriye ait Index'e gelip küçük bir değişiklik yapıyoruz. Güncelleme işleminde Guncelle sayfası yerine KategoriGetir sayfasına gitmesini sağlıyoruz.<br><br>

<hr>

# 🖥️ Mvc Ders 29 - Kategori Güncelleme Sayfası Oluşturma

KategoriGetir sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4af0aeb2-2bca-4c08-ae13-383c7e9c0202)
<br>
En üst kısma bir tane model oluşturuyoruz.<br>
Burada @using Html.BeginForm kullanıyoruz. İlk parametrede Action yani metodun ismini, ikinci parametrede Controller ismini, üçüncü parametrede FormMethod Get veya Post işlemini yazıyoruz.<br>
Ardından div kullanarak tasarımı düzgün hale getirmeyi sağlıyoruz. Burada LabelFor ve TextBoxFor etiketlerini kullanıyoruz. LabelFor etiketin gözükeceği kısım, TextBoxFor metin kutusunu gösteren kısımdır. ID ve AD değerlerini gösteriyoruz.<br>
En altta bir tane buton oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7e85642c-f417-4e82-9c1f-f0717e471eb4)
<br>
Herhangi bir kategori işlemi için GÜNCELLE butonuna tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d44f223f-da13-4136-a779-ce6b9e2550c2)
<br>
Burada güncelleme sayfası tasarımını oluşturduk.<br><br>

<hr>

# 🖥️ Mvc Ders 30 - Küçük Bir Tanıtım :)

![image](https://github.com/user-attachments/assets/bdcd1ea6-148c-4521-8e7d-379f816dc6f4)
<br>
Kategori Sayfası<br><br>

![image](https://github.com/user-attachments/assets/76df46d5-7e87-48c0-9e8d-c6f2526f96ba)
<br>
Kategori Ekleme İşlemi<br><br>

![image](https://github.com/user-attachments/assets/1a312a7d-082a-4910-8244-65ee389fa612)
<br>
Ürün Sayfası<br><br>

![image](https://github.com/user-attachments/assets/c3f8ad23-8b97-40bf-8a75-a803a8cbaef7)
<br>
Ürün Ekleme İşlemi<br><br>

![image](https://github.com/user-attachments/assets/276debcd-799b-4b63-a31a-0f607729ca88)
<br>
Müşteri Sayfası<br><br>

![image](https://github.com/user-attachments/assets/40a0cdb1-b852-41b3-b93f-38fef56b2ed5)
<br>
Müşteri Ekleme İşlemi<br><br>

<hr>

# 🖥️ Mvc Ders 31 Kategori Bilgisi Güncelleme

![image](https://github.com/user-attachments/assets/2b3c5ec4-5fb8-49c7-8a00-c64237b01a2a)
<br>
Burada Guncelle metodunu oluşturup TBLKATEGORILER tablosuna ait olan p1 değişkenini ekliyoruz.<br>
Burada ktg değişkenini kullanıp ID değerini bulmak için Find metodunu kullanıyoruz.<br>
Ardından güncellenecek alanlar hangisiyse onları tek tek yazıyoruz. Burada KATEGORIAD isminde tek bir alan olduğu için ktg değişkenindeki KATEGORIAD ile p1 değişkenindeki KATEGORIAD değerlerini eşitliyoruz.<br>
Ardından değişiklikleri kaydediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/75dc5f7b-1bb5-4a99-a630-a523bfe6cd03)
<br>
DİĞER ÜRÜNLER ismini DİĞER olarak güncelleyelim.<br><br>

![image](https://github.com/user-attachments/assets/a17a0a1f-e151-416b-8590-775c66dcc5c3)
<br>

![image](https://github.com/user-attachments/assets/60765ef8-4a1a-4767-a423-8d97144b07ab)
<br><br>

<hr>

# 🖥️ Mvc Ders 32 - Müşteri Bilgilerini Güncelleme Sayfasına Taşıma

![image](https://github.com/user-attachments/assets/6de89c75-8eee-4586-8049-12a3b581a4de)
<br>

![image](https://github.com/user-attachments/assets/86943d2f-c826-4a8f-8fad-52c850313135)
<br>
Index sayfasına gidip Güncelleme işleminde Guncelle sayfası yerine MusteriGetir sayfasına gitmesini sağlıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/bce7015d-88a3-4d3b-99b9-c0b05140c709)
<br>

![image](https://github.com/user-attachments/assets/26cbe62b-a80f-4aa8-8044-85279a681ff8)
<br><br>

<hr>

# 🖥️ Mvc Ders 33 - Müşteri Bilgilerini Güncelleme

![image](https://github.com/user-attachments/assets/dd13fc16-50a1-478a-b0fb-eb8881b98683)
<br>

![image](https://github.com/user-attachments/assets/818c4378-3798-45fb-8573-97dd7b1b600d)
<br>
Buradan Yeliz Asya adlı müşterinin ismini ve soyismini büyük harflerle güncelleyelim.<br><br>

![image](https://github.com/user-attachments/assets/9e66fa3e-d7ed-424a-a52c-d80b57ce967a)
<br>

![image](https://github.com/user-attachments/assets/6578ff44-ae3a-47f0-8ee8-5383924ba027)
<br><br>

<hr>

# 🖥️ Mvc Ders 34 - Validation Kontrolleri Required
ASP.NET MVC'de Validation (Doğrulama) Kontrolleri, kullanıcıdan alınan verilerin doğruluğunu sağlamak için kullanılır. MVC, doğrulama işlemlerini hem istemci (client-side) hem de sunucu (server-side) tarafında yapmayı destekler.<br><br>

### 1. Data Annotations ile Model Bazlı Doğrulama
Data Annotations, model üzerinde [Required], [StringLength], [Range] gibi öznitelikleri (attribute) kullanarak doğrulama yapmayı sağlar.<br>
Örnek Kullanım:<br><br>

public class KullaniciModel<br>
{<br>
    [Required(ErrorMessage = "Ad alanı zorunludur.")]<br>
    [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir.")]<br>
    public string Ad { get; set; }<br>
<br>
    [Required(ErrorMessage = "Email alanı boş olamaz.")]<br>
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]<br>
    public string Email { get; set; }<br>
<br>
    [Range(18, 60, ErrorMessage = "Yaş 18 ile 60 arasında olmalıdır.")]<br>
    public int Yas { get; set; }<br>
}<br><br>

💡 Bu modelde:<br><br>
💠 Required: Boş bırakılamaz.<br>
💠 StringLength(50): Maksimum 50 karakter olabilir.<br>
💠 EmailAddress: Geçerli bir e-posta olup olmadığını kontrol eder.<br>
💠 Range(18, 60): 18 ile 60 arasında olmasını zorunlu kılar.<br><br>

### 2. Controller'da Doğrulama Kontrolleri
ModelState.IsValid, modelin doğrulama kurallarına uyup uymadığını kontrol eder.<br><br>

public ActionResult Kaydet(KullaniciModel model)<br>
{<br>
    if (ModelState.IsValid)<br>
    {<br>
        // Verileri kaydetme işlemi yapılır.<br>
        return RedirectToAction("Basari");<br>
    }<br>
<br>
    return View(model);<br>
}<br><br>

💡 ModelState.IsValid: Model doğrulamalarını kontrol eder. Eğer hata varsa form tekrar gösterilir.<br><br>

### 3. View Katmanında Validation Mesajlarını Gösterme
View tarafında doğrulama mesajlarını göstermek için Html.ValidationMessageFor kullanılır.<br>
Örnek Kullanım (View - Razor): <br><br>

@model KullaniciModel<br>
<br>
<form asp-action="Kaydet" method="post"><br>
    <label>Ad:</label><br>
    <input asp-for="Ad" /><br>
    <span asp-validation-for="Ad" class="text-danger"></span><br>
<br>
    <label>Email:</label><br>
    <input asp-for="Email" /><br>
    <span asp-validation-for="Email" class="text-danger"></span><br>
<br>
    <label>Yaş:</label><br>
    <input asp-for="Yas" /><br>
    <span asp-validation-for="Yas" class="text-danger"></span><br>
<br>
    <button type="submit">Kaydet</button><br>
</form><br>
<br>
@section Scripts {<br>
    @await Html.PartialAsync("_ValidationScriptsPartial")<br>
}<br><br>

💡 <b>Önemli Noktalar:</b><br>
💠 asp-validation-for="AlanAdi" ile hata mesajlarını görüntüleyebiliriz.<br>
💠 _ValidationScriptsPartial, istemci tarafında jQuery validation çalıştırır.<br><br>

![image](https://github.com/user-attachments/assets/ec3de70d-9003-493b-bf9d-4167f2e11505)
<br>
Models klasörüne gelip Entity klasöründe yer alan Model'e tıklayıp Model1.tt'den TBLKATEGORILER.cs tablosunu seçiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/45546b70-6971-40ca-941c-87c7eb2f6703)
<br>
TBLKATEGORILER sayfası bu şekilde çıkmaktadır. Buradan Validation işlemlerimizi yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/250a0c21-3a8d-4ec2-8036-07dd83b6aad7)
<br>
Burada KATEGORIAD sütununu boş geçmemek için hemen üzerine Required ekliyoruz. Bunun için using System.ComponentModel.DataAnnotations; kütüphanesini ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/568f7f4d-739b-4bbd-a89f-3142d848ecb0)
<br>
Kategori ekleme sayfasına gidiyoruz ve herhangi bir şey yazmadan direkt Kategori Ekle butonuna tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/839ffd0e-a90d-4bb5-9831-7370b1d040e3)
<br>
Bu şekilde hata vermektedir. Bunun yerine hata mesajı ekleyebiliriz.<br><br>

<hr>

# 🖥️ Mvc Ders 35 - Validation Kontrolleri 2 Required

![image](https://github.com/user-attachments/assets/d2a7c4d5-6d04-4a5a-95b7-6f381fa62a16)
<br>
TBLKATEGORILER sayfasına geldik. Burada bir hata mesajı eklemiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/e11d61bf-369d-4a40-9c4c-cd44eee02c4c)
<br>
YeniKategori sayfasına gelip birkaç değişiklik yapıyoruz. En üste bir model oluşturuyoruz.<br>
TextBoxFor ekledikten sonra burada hata mesajını göstermesi için ilk olarak ValidationMessageFor etiketi oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/e4a20729-5068-487a-bd81-c07611502acd)
<br>
KategoriController'a gelip HttpPost işlemindeki YeniKategori'ye bir şart belirliyoruz. Burada doğrulanma işlemi yapılmadıysa direkt View kısmından YeniKategori sayfasına döndürecektir.<br><br>

![image](https://github.com/user-attachments/assets/9aa2b9a9-eb5f-45a7-8c60-0c5319fa7435)
<br><br>

<hr>

# 🖥️ Mvc Ders 36 - StringLength Validation

![image](https://github.com/user-attachments/assets/580c0db6-6dd0-4472-8555-9db9e031d9ec)
<br>
TBLMUSTERILER tablosu üzerinden validasyon işlemlerini yapıyoruz. Burada maksimum 50 karakter alabilme özelliğini ekledik.<br><br>

![image](https://github.com/user-attachments/assets/0e4341a9-798b-48a9-bf03-974631ed8544)
<br>

![image](https://github.com/user-attachments/assets/89eb70d3-597c-4ba9-a42f-c27c9ef3f73e)
<br>

![image](https://github.com/user-attachments/assets/c62128a7-1dba-4c7c-b5ee-e1451866a42b)
<br><br>

<hr>

# 🖥️ Mvc Ders 37 - Ürün Bilgilerini Taşıma

![image](https://github.com/user-attachments/assets/2397d9cf-5e2b-48e7-a61c-18b6dc677525)
<br>

![image](https://github.com/user-attachments/assets/e13dc1c3-9682-4fb6-88ef-294b385d5293)
<br>

![image](https://github.com/user-attachments/assets/65cd3af4-213f-443e-b70d-33c1907e31cb)
<br><br>

<hr>

# 🖥️ Mvc Ders 38 - Ürün Kategori Bilgisi Getirme

![image](https://github.com/user-attachments/assets/155010a4-58a4-4e74-99dd-6c64f5fefd8f)
<br>

![image](https://github.com/user-attachments/assets/1aa90b79-48f0-4cd2-b57d-f87e6bf9e587)
<br>

![image](https://github.com/user-attachments/assets/a360d1b4-2583-4ed8-83a8-4056e2fe16d1)
<br><br>

<hr>

# 🖥️ Mvc Ders 39 - Ürün Güncelleme ~ 1

![image](https://github.com/user-attachments/assets/30aecede-f57d-44f1-9392-0473008e82ac)
<br>

![image](https://github.com/user-attachments/assets/42158f4a-e115-4749-a1dd-437aa4db0355)
<br>
Güncelleme işleminde URUNKATEGORI kısmı normalde smallint değerindedir. Burada ekleme işlemi yaptığımız zaman ürüne ait kategori seçerken bize metinsel ifade olarak göstermektedir, ancak güncelleme işleminde direkt ID değerine göre aldığımız zaman, burada kategoriyi değiştireceğimiz zaman bize hata döndürecektir, ancak diğer değerleri güncelleyecektir.<br><br>

![image](https://github.com/user-attachments/assets/815ba0d7-41a5-40a1-99fa-9a6baa88a955)
<br>
Hata ekranı bu şekildedir. Hatanın önüne geçebilmek için SQL'e gelip URUNKATEGORI değerini tekrardan girmemiz gerekmektedir.<br>
Bir sonraki kısımda doğru kullanım gösterilecektir.<br><br>

<hr>

# 🖥️ Mvc Ders 40 - Ürün Güncelleme ~ 2

![image](https://github.com/user-attachments/assets/56dff83f-dc6a-4aa9-9988-0235b4e7fdb4)
<br>

![image](https://github.com/user-attachments/assets/b1bb8c54-b490-4523-a593-01f49458d4a3)
<br>
LCD ürünün kategorisini BEYAZ EŞYA yerine DİĞER ÜRÜNLER olarak güncelleyelim.<br><br>

![image](https://github.com/user-attachments/assets/9453e2c4-e1da-4882-b81b-fdbf1892e682)
<br>

![image](https://github.com/user-attachments/assets/159ee6d1-6e01-4dd8-b57f-26aa69059402)
<br><br>

<hr>

# 🖥️ Mvc Ders 41 - Ürün Validation Kontrolleri

![image](https://github.com/user-attachments/assets/5c389d72-aa8e-498d-b598-1a996a6774ba)
<br>
Burada Entity kısmından Models'e ait TBLURUNLER sayfasından validasyon işlemleri yerine direkt YeniUrun sayfasına gelip HTML'ye ait olan validasyon işlemlerini uyguladık.<br><br>

![image](https://github.com/user-attachments/assets/33d35931-09a0-480b-816a-e2f1da392b05)
<br><br>

<hr>

# 🖥️ Mvc Ders 42 - Sayfalama (Paging)

⚠️ Sayfalama işleminden önce bir not: ? ile ?? ne işe yarar?<br><br>

C#'ta ? ve ?? operatörleri, null değerlerle çalışırken kullanılan önemli operatörlerdir.<br>
### 1. ? (Nullable Tip Tanımlama)
? operatörü, bir değer tipinin (int, double, bool vb.) nullable (null alabilir) versiyonunu oluşturmak için kullanılır.<br>
Örnek:<br><br>

int? sayi = null; // Nullable int<br>
double? ondalikliSayi = 3.14; // Nullable double<br>
bool? durum = null; // Nullable bool<br><br>

<b>Açıklama:</b><br><br>
Normalde int, double, bool gibi değer tipleri null alamaz.<br>
int? gibi bir tanımlama yaparak null değer atayabiliriz.<br>
Nullable<T> ile aynı anlama gelir, yani int? aslında Nullable<int> ile aynıdır.<br><br>

<b>Null Kontrolü Yapma</b><br><br>
Bir nullable değişkenin değerinin olup olmadığını kontrol etmek için .HasValue ve .Value kullanılabilir:<br><br>

int? yas = 25;<br>
if (yas.HasValue)<br>
    Console.WriteLine($"Yaş: {yas.Value}");<br>
else<br>
    Console.WriteLine("Yaş belirtilmedi.");<br><br>

### 2. ?? (Null Coalescing - Null Birleştirme Operatörü)
?? operatörü, bir değişken null ise varsayılan bir değer atamak için kullanılır.<br>
Örnek:<br><br>

int? sayi = null;<br>
int sonuc = sayi ?? 100; // Eğer sayi null ise 100 atanır<br>
Console.WriteLine(sonuc); // Çıktı: 100<br><br>

<b>Açıklama:</b><br><br>
sayi ?? 100 ifadesinde sayi değişkeni null değilse kendi değerini kullanır, eğer null ise 100 atanır.<br><br>

![image](https://github.com/user-attachments/assets/6ec8e3e0-408c-4c58-ad34-6b3619bf633e)
<br>
Bu operatörler özellikle veri tabanı işlemleri, form kontrolleri, nullable değerlerle çalışırken oldukça faydalıdır.<br><br>

## Sayfalama İşlemi
İlk olarak katmanımıza sağ tıklayıp Manage NuGet Packages diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e78fa461-2bf1-4391-9d72-cd4b07c7cc36)
<br>
İndireceğimiz paket PagedList.Mvc olacaktır.<br><br>

KategoriController'a gelelim.<br><br>

![image](https://github.com/user-attachments/assets/aa65b173-4b6c-4377-b4da-54f357e05a23)
<br>
Burada using PagedList ve PagedList.Mvc adında iki tane kütüphane ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/dc4efcfb-3076-41d6-9cb6-3d0979b81a9f)
<br>
Burada listeleme işlemine geldiğimizde ToList metodundan sonra ToPagedList metodunu ekliyoruz. Buradaki birinci değer sayfanın başlangıcı, ikinci değer ise her sayfada kaç adet olduğunu belirtir.<br><br>

![image](https://github.com/user-attachments/assets/3c04fe86-25ab-43cd-ae40-63164ec8239c)
<br>
Index üzerinden çalıştırdığımız zaman bize hata verecektir.<br><br>

![image](https://github.com/user-attachments/assets/1c695973-b0dc-4842-8dfb-25080a505a74)
<br>
Index'te en üstte oluşturduğumuz @model kısmını PagedList.IPagedList olarak değiştiriyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c3e5879c-2784-4ed2-9b3b-3c6176da9553)
<br>
Index üzerinden çalıştırdığımızda 4'e kadar olan değerleri göstermesini sağladık, ancak burada sayfalama işlemini henüz tamamlamadık.<br><br>

![image](https://github.com/user-attachments/assets/b8c02ea6-490c-4598-b17f-c66adf978fe3)
<br>
Tekrar Index'e gelip en üst tarafa iki tane daha kütüphane ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/2db990b6-4076-454f-98a6-b771688cc244)
<br>
Burada bir değişiklik daha yaptık. ActionResult Index'ten sonra içerisine int türünden sayfa isminde bir değişken tanımlayıp 1'den başlattık. Tekrardan Index'e dönelim.<br><br>

![image](https://github.com/user-attachments/assets/aaadaeda-95fd-47f5-a63d-abd32502eb4b)
<br>
Index sayfasında en altın bir üstüne gelip Html parametrelerinden biri olan PagedListPager ekliyoruz.<br>
İkinci parantezin içerisinde IPagedList ekliyoruz. IPagedList yukarıda tanımlamış olduğumuz Model değeri olarak kullanacağımız alandır.<br>
KategoriController'da yer alan Index'te tanımlamış olduğumuz sayfa değişkenini buraya ekliyoruz.<br>
Ardından Lambda Expression kullanarak Url.Action ile yönlendiriyoruz.<br>
Birinci parametre Index'e yönlendirmesini, ikinci parametre ise new oluşturup sayfa değişkenini ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4952fdbc-54a6-4c18-b3ba-0e47d2fd527e)
<br>
Çalıştırdıktan sonra sayfalama işlemi bu şekilde tamamlandı.<br><br>

<hr>

# 🖥️ Mvc Ders 43 - Alert Kullanımı

MusteriController için bir örnek yapalım. YeniMusteri sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c146c42d-6462-4ab0-80c3-3d7b5b6c19e8)
<br>
Burada oluşturduğumuz YENİ MÜŞTERİ EKLE butonunda yer alan class işleminden sonra bir tane id ekliyoruz, burada istediğiniz ismi verebilirsiniz. Örnek olarak ismini btn1 olarak belirledik.<br>
Ardından </form> etiketinden önce <script> etiketini açıyoruz ve içerisine $ işaretini ekliyoruz.<br>
Ardından # işaretini ekledikten sonra tanımladığımız id değerini yazıp click metodunu ekliyoruz, ardından function ekliyoruz.<br>
Burada alert dedikten sonra mesaj vermesini sağlıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/fd7d1830-d87a-4369-b86f-c45777c70e79)
<br>
Müşteri ekleme işlemi yaptıktan sonra mesajı göstermiş oldu.<br><br>

<hr>

# 🖥️ Mvc Ders 44 - Alert ile Silme

MusteriController üzerinden devam edelim. Index sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/1893014e-7aef-4afa-9215-a8f6f884ad81)
<br>
Burada ALERT isminde bir tane daha sütun ekledik.<br><br>

![image](https://github.com/user-attachments/assets/a6a0ef20-1568-4f64-813f-c3ad9ca87757)
<br>
Ardından ALERT sütununa karşılık gelen değeri yazdık.<br>
Burada SİL BUTONU üzerinde yazacak olan değer, SİL ActionResult değerini, new değerinde ise id değeriyle birlikte MUSTERIID'yi taşıyacaktır.<br>
Ardından butona bir class ataması yapıyoruz.<br>
Burada onclick komutu ise tıkladıktan sonra evet/hayır penceresi gelecektir, ardından return confirm işleminde bize bir mesaj gösterecektir.<br><br>

![image](https://github.com/user-attachments/assets/fc39fc3d-c38c-426c-9274-68910051f390)
<br>
ID 7 değerini silmek istediğimiz zaman uyarı penceresi gelecektir. Tamam diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5718ddb8-c780-479e-854e-fd6136284cc3)
<br>
Silme işlemi ALERT üzerinden bu şekilde yapıldı.<br><br>

<hr>

# 🖥️ Mvc Ders 45 - Popup Modal Kullanımı

Yeni bir Controller oluşturalım ve ismini SatisController olarak belirleyelim.<br><br>

![image](https://github.com/user-attachments/assets/640b8980-ee4a-4eec-acae-296a42a8d554)
<br>
Ardından bir View oluşturalım ve bağlantı adresini _MainLayout üzerinden verelim.<br><br>

![image](https://github.com/user-attachments/assets/3303d074-b37d-4c17-bf68-c4a6ad745bad)
<br>
Index'e geldiğimizde ilk butona class atamasından sonra data-toggle ekliyoruz, data-toggle başlığı belirtir. Geçişi modal olacaktır.<br>
Ardından data-target ise bunun hedefini gösterir. İsmini #Modal1 olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3dd0662d-f619-4d69-8051-64bee340a520)
<br>
Button tanımlamasından sonra div etiketleri içerisine ilk olarak modal isminde bir class tanımlıyoruz ve id değerini butonda tanımladığımız id değerini yazıyoruz.<br>
Ardından ikinci div etiketinde bir tane modal-dialog oluşturuyoruz.<br>
Üçüncü div etiketinde modal-content ile içeriğini oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c2ab7fd2-7dbd-495f-8246-9825e6a4a91b)
<br>
Satış Yap butonuna tıkladığımızda ekran karardı, ancak içerisine herhangi bir şey yazmadık.<br><br>

![image](https://github.com/user-attachments/assets/fbc2c6d7-afdb-469b-bf60-5976b836ac4e)
<br>
Burada modal-content tanımladıktan sonra modal-header ekleyerek bir başlık belirledik.<br>
Ardından başlık için h2 etiketini kullanarak modal-title oluşturduk ve ismini Satış Yapma Ekranı olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/a17a9442-207a-451a-a3bf-7f54b809a3d7)
<br>
Butona bastığımızda karşımıza bu şekilde çıkmış oldu.<br><br>

![image](https://github.com/user-attachments/assets/02f98999-cc52-4220-ab14-0ba6db818a50)
<br>
Satış Yapma Ekranı başlığındaki div etiketinden hemen sonra bir tane form etiketi oluşturduk.<br>
Burada bir tane div tanımlaması yapıp modal-body oluşturduk.<br>
Ardından label etiketine Ürün Adı ismini vermiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/075b7eaf-5b46-4e6e-b51a-0c721f3eb9a4)
<br>
Butona bastığımızda karşımıza bu şekilde çıkmış oldu.<br><br>

![image](https://github.com/user-attachments/assets/33cfe234-28c5-4941-9c91-5bf06833f0d2)
<br>
Ürün Adı için bir tane TextBox ataması yapıyoruz. Burada input type türüne text, name kısmına geçici olarak Urun, class ise form-control olarak belirledik.<br><br>

![image](https://github.com/user-attachments/assets/c8d6cbeb-2195-42d2-ac77-7f44c3d51849)
<br>
Butona bastığımızda artık TextBox eklenmiş oldu.<br><br>

![image](https://github.com/user-attachments/assets/b84b017b-b401-483e-9ab2-fab84f10ab1d)
<br>

![image](https://github.com/user-attachments/assets/d1f6b758-1222-4722-87d5-77b0e6ad03fa)
<br><br>

<hr>

# 🖥️ Mvc Ders 46 - Popup Modal Üzerine Satış Ekleme

![image](https://github.com/user-attachments/assets/68a30933-a6d1-4529-b676-fe40830ecb56)
<br>
Örnek bir satış verisi...<br><br>

![image](https://github.com/user-attachments/assets/ac1bc35f-10c6-4085-a785-8d2b0cc7f26a)
<br>

Index üzerinden devam ediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/cd3317b6-d5a6-428d-aeaf-dc11caef9c78)
<br>
En üstte modeli oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a316a8a6-1e32-406c-bcf0-c3b5739f9061)
<br>
Burada form etiketinden sonra verileri eklemek için method işlemini post olarak belirliyoruz.<br>
Ardından action işleminde ise Controller'a ait olanı (Satis) ve oluşturduğumuz ekleme işlemi olan YeniSatis'a yönlendiriyoruz.<br>
Kalan işlemleri ise input yerine Html parametrelerini kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a2bf4cc8-fcc1-4b40-a65d-016b77014895)
<br>

![image](https://github.com/user-attachments/assets/fe2f8e4e-3e1c-4522-9d44-bfb2c319eca8)
<br>
SQL veriye kaydedildi.<br><br>

<hr>

# 🖥️ Mvc Ders 47 - Popup Modal Vazgeç Seçeneği

![image](https://github.com/user-attachments/assets/19af35d2-adf6-4405-a5c8-dfc6c9b3d9f1)
<br>
Index sayfasının en altında yer alan Satış İşlemini Yap butonuna bir tane type ekliyoruz ve submit olarak belirliyoruz. Submit işleminin tamamlanacağı anlamına gelir.<br>
Vazgeç işleminde ise ilk olarak type türünü button olarak belirledik. Burada vazgeçme işlemi için data-dismiss komutunu kullandık. Vazgeçmek, iptal etmek anlamında kullanılır.<br><br>

![image](https://github.com/user-attachments/assets/b9fe3fef-1c0b-45dd-a61c-a93a4fe3bb64)
<br>
Vazgeç butonuna bastığımız zaman veriyi eklemeyecektir.<br><br>

<hr>

# 🖥️ Mvc Ders 48 - Arama Paneli

MusteriController üzerinden işlemlerimizi yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f6a33b6c-a3e9-4615-a46a-1e079db9befa)
<br>
Burada Index içerisindeki parametreyi string olarak belirleyip p isminde bir değişken oluşturduk.<br>
Ardından bir tane LINQ sorgusu oluşturduk.<br>
Daha sonra geriye değer döndürme işlemini uygulamış olduk. Index sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/59b50341-54e7-46d8-a706-13027d39a20d)
<br>
Burada Html BeginForm oluşturarak Action ismini, Controller ismini yazdıktan sonra arama işlemi için Post yerine Get metodu kullanıyoruz.<br>
Ardından bir tane p etiketi açarak buraya bir metin ekliyoruz. Ekledikten sonra burada Html parametresini kullanarak TextBox olarak belirliyoruz ve içerisine "p" olarak ekliyoruz. Buradaki "p" Controller'da string olarak tanımladığımız p değişkenidir.<br>
Bir tane buton ekliyoruz ve type türüne submit olarak belirliyoruz. Value değeri butonda gözükecek olan isimdir.<br><br>

![image](https://github.com/user-attachments/assets/9fb80b20-e25c-4df2-bfe9-006431ebb419)
<br>

Burada herhangi bir müşterinin ismini aradığımız zaman bize herhangi bir sonuç döndürmeyecektir. Bunun için tekrardan MusteriController'a gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/05e61690-82c0-45cd-a0bd-b50e43fa256c)
<br>
Burada var degerler olarak tanımladığımız LINQ sorgusundan sonra bir tane if şartı yazıyoruz. Bu şart, eğer gireceğimiz değer boş olmama durumunu kontrol etmektedir.<br>
Eğer arama çubuğuna yazacağımız değer boş olmazsa burada bir tane Where şartı yazıyoruz. Buradaki şart MUSTERIAD sütununda yer alan isimler, arama çubuğuna yazdığımız değeri içeriyorsa işlemi gerçekleştireceği anlamına gelmektedir.<br><br>

![image](https://github.com/user-attachments/assets/9d84342c-e4c9-4d0d-87f7-d2731b18d0c1)
<br>
EMEL yazdığımız zaman EMEL ismindeki müşterileri getirecektir. Sadece E yazarsak içerisinde E harfi geçen müşterileri getirecektir.<br><br>

<hr>

# 🖥️ Mvc Ders 49 - Datatable Jquery Eklentisi (Paging & Search)

Burada bir tane DataTable ekleyeceğiz. Bu eklenti sayesinde arama panelini veya sayfalama işlemini uzun uzun yapmak yerine tamamını tek bir eklenti üzerinden çok kolay bir şekilde yapabiliriz.<br>
Bunun için katmanımıza sağ tıklayarak Manage NuGet Packages diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/606c99d5-ff41-4286-b456-2f278dbb570d)
<br>
Burada ekleyeceğimiz paketin ismi jquery.datatables olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/93dbef90-17b0-4240-b7b9-e54c95c8895e)
<br>
Paket kurulduktan sonra Content klasöründe yer alan DataTables klasörü oluşturuldu.<br><br>

UrunController'dan Index sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d0cd58a7-edd0-4391-9180-0bf870e57d5d)
<br>

Burada ilk olarak oluşturduğumuz table etiketi içerisine bir tane id ekliyoruz ve ismini tbl1 olarak belirliyoruz.<br>
Ardından oluşturduğumuz tr etiketleri içerisine thead etiketini ekleyerek tüm başlıkları tek bir çatı altında topluyoruz.<br>

![image](https://github.com/user-attachments/assets/2cf72388-e1f1-4bc0-b884-c10aa9a5ff2f)
<br>
Buradaki kodları en alta yazıyoruz.<br>
❗ Oluşturulan DataTables klasörü içerisinde yer alan css klasörüne gidiyoruz ve seçeceğimiz dosya ismi dataTables.bootstrap4.css olacaktır. Ekleyeceğimiz kod satırı aşağıda yer verilmiştir.<br><br>

<link href="~/Content/DataTables/css/dataTables.bootstrap4.css" rel="stylesheet" /> <br><br>

❗ Bir diğer ekleyeceğimiz script dosyası aşağıda yer verilmiştir, https://datatables.net/ sitesinden JS dosyasını ekleyebilirsiniz.<br><br>

<script type="text/javascript" src="https://cdn.datatables.net/2.2.2/js/dataTables.min.js"></script> <br><br>

![image](https://github.com/user-attachments/assets/6a6ffd6d-906c-48bd-90ff-f3010f939775)
<br>
Burada en alta bir tane script oluşturup table etiketinde verdiğimiz id değeri olan tbl1'i buraya ekliyoruz ve tablo oluşturmak için DataTable komutunu ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/02584a52-e64c-469c-9179-5b78916495d9)
<br>
DataTable görünümü bu şekildedir. Sol üst köşede yer alan entries per page kısmına gelip her bir sayfada kaç tane eleman sayısını gösterecektir. Burada başlangıçta 10 tane gösterdikten sonra yeni bir sayfaya gidecektir. Altında da hemen bir arama çubuğu bulunmaktadır. Arama çubuğunda herhangi bir harfe bastığımızda ilgili veriyi gösterecektir.<br><br>

<hr>

# 🖥️ Mvc Ders 50 - Final

Bu eğitim bana gerçekten çok şey kattı. Daha önceden C# ve SQL bilgilerim sayesinde MVC'nin temel kavramından başlayarak nasıl bir Controller, View oluşturulacağını, nasıl bir proje hazırlanacağını öğrenerek bilgi birikimimi daha da arttırmış oldum. Eğitim boyunca vermiş olduğu bilgilerle pekiştirmemi sağladığı için Sayın Murat Yücedağ'a çok teşekkür ederim.
