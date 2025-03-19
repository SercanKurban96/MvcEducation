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

![image](https://github.com/user-attachments/assets/9bd558af-727b-4e65-8c42-940e3e26911a)
<br>
HomeController'da Index, About ve Contact isminde üç tane alanımız bulunmaktaydı. Burada yeni bir tane alan tanımlıyoruz ve ismini Bilgi olarak belirledik. Bunun sonucunda bize direkt View olarak döndürmesini sağlıyoruz.<br><br>

### ⚠️ <b>View oluşturmak için uygulanacak adımlar:</b>

![image](https://github.com/user-attachments/assets/3d256ad5-4774-428e-8570-321b0f7fb326)
<br>
Oluşturduğumuz ActionResult'tan Bilgi ismini verdiğimiz alana sağ tıklayıp "Add View" diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0ce96bd8-e209-47fe-9910-9f3c8f5e25c8)
<br>
Karşımıza bu şekilde çıkacaktır. Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/92f89ec3-f04a-45fa-b63e-f649982a349c)
<br>
View ekleme alanı bu şekilde karşımıza çıkacaktır. Burada Use Layout Page kısmı seçili olarak gelecektir. Oluşturacağımız View'a Layout eklemek için sağında bulunan ... işaretine tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/37208896-12c2-4430-ab8e-36ccb8ccf0db)
<br>
Karşımıza bu şekilde çıkacaktır.<br><br>

![image](https://github.com/user-attachments/assets/f5395041-a90c-499b-a64a-7f8897ff98bb)
<br>
Burada Layout seçebilmek için Views klasörüne geliyoruz ve hemen ardından Shared klasörüne tıklıyoruz. Shared klasörüne tıkladıktan sonra iki tane sayfa karşımıza çıkacaktır. Burada Layout ekleyeceğimiz için _Layout.cshtml sayfasını seçiyoruz ve OK diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9c357169-1279-4d11-96b2-f29afe23823f)
<br>
Layout sayfamız hazır. Add diyoruz ve biraz bekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/72ca3988-be6a-48f6-b5e7-d6f4ac151a6e)
<br>
Bilgi sayfası bu şekilde gelmiş oldu.<br><br>

![image](https://github.com/user-attachments/assets/8c2a7bce-9b7e-4658-89f9-b5e0ca47c791)
<br>
Layout.cshtml sayfasına gidip oluşturduğumuz Bilgi sayfasına ait yeni bir alan ekleyelim.<br><br>

![image](https://github.com/user-attachments/assets/9f5ac4ac-9617-4bf9-a5aa-28dba5d5688f)
<br>
Bilgi sekmesi karşımıza bu şekilde çıkmış oldu.<br><br>

<hr>


