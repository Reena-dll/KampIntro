#OOP presiplerini kullanarak bir proje tasarlarken program değişkenlerini tuttuğumuz
class'da fonksiyonları tutmuyoruz , fonksiyonları tuttuğumuz class'da değişkenleri
tutmuyoruz.



#MşteriNo , VergiNo ve Tc gibi yapılar string olarak tutulur , long olarak tutulmaz
çünkü bir değişken üzerinde aritmetik işlemler yapmıyorsan onu sayısal bir veri 
türüyle tutmanın mantığı yoktur



#CRUD=Cread,Read,Update,Delete



#Entitie=Varlık ; Varlıklar mesela customer , employee , product veya personel 
isminde ki sınıflar yani içerisinde sadece özellik tutan sınıflara entitie yani 
varlık deniyor , varlık sınıflarının içinde operasyonlar olmaz 



#Varlık sınıflarını yönettiğimiz yani kuralları yazdığımız sınıflara , 
busıness class denir.



#Yazım Kuralları ;
PascalCase = ProductManager
camelCase = productManager
Sınıf isimleri ve fonksiyon isimleri PascalCase , 
nesne isimleri ise camelCase yazılır



#Okunurluğu artırmak için interface isimleri I harfiyle başlatılır ; IKrediManager 
gibi



#Engin Demiroğ İnterface'i base operasyon class olarak kullandı , genellikle 
operasyonel class'larda kullanılıyor interface'ler



#İnterface'leri birbirinin alternatifi olan ama kod içerikleri birbirinden farklı 
olan durumlar için kullanırız , misal bir bankada yüzlerce kredi türü vardır ve 
tüm kredi türleri Hesapla adında bir fonksiyon kullanır bu durumda , kredileri class
olarak oluşturur IKrediManager adında da bir interface oluşturur ve tüm kredi
türü classlara IKrediManager'ı implement ederiz



#İnterface'lerin sonuna Service denir ILoggerService , IKrediService gibi



#Interface'ler bir referans tutucudur , class'ların referansını tutar yani onun için
kullanılır



#Büyük projelerde ICustomerDal isminde bir interface olur ve veri tabanı işlemleri
buradan yapılır , büyük projelerde SQL için ayrı Oracle için ayrı veri tabanı 
işlemleri yapılır o yüzden SqlServerCustomerDal:ICustomerDal deriz ve Sql veri 
tabanı kodlarını yazarız aynı şekilde oracle için de yaparız DAL=Data Access Layer , 
bu interface içinde CRUD işlemlerinin ön tanımlaması yapılır



#Veritabanı oluştururken en sol sütunda id daha sonra tablonun başka sütunlarla  
ilişkili olan sütunları ve sonra tablomuzun kendi özelik sütunları gelir



#Veritabanı kolonlarına "as" keywordü ile verdiğimiz takma adlara "alias" deniyor
örnek : select City as Sehir from tblCustomer



#RDBMS(Relational Database Management System) =>Oracle,SqlServer,MySql,PostgreSql,Acess
NoSql(Not Only SQL=İlişkisellikten öte) 



#C# da bir interface'in default erişim belirleyicisi Internal'dır ancak Interface
içindeki yapıların default erişim türü public'dir



#Projelerde global değişkenlerin başına alt tire konur ve camelCase yazılır



#LINQ açılımı => Language Integrated Query 



#EntityFramework bir ORM(Object Relation Mapping) dir yani nesnlerin veritabanı ile
bağdaştırılması için kullanılan sistem



#Katmansal mimaride Core katmanı olarak belirlediğimiz kısım diğer katmanları asla
referans almaz çünkü Core katmanı bir projeye ait olmamalıdır istenilen projede 
Core katmanı kullanılmalıdır yani Core katmanı bir projeyi referans almaz proje Core
katmanını referans alır



#DTO=Data Transformation Object : Genelde Join sınıflarının miras aldığı 
Interfaceleri isimlendirirken kullanılır



#Public fieldlar PascalCase yöntemiyle oluşturulurken Private fieldlar camelCase yöntemiyle isimlendirilir



#Getter(ReadOnly'ler) proplar constructor içinde set edilebilir



#Fonksiyonlar tek bir değer tipi döndürür ancak birden çok olay döndürmek istiyorsak encapsulation yöntemlerini 
kullandığımız bir sınıf oluşturur , fonksiyonumuzun dönüş tipinide bu sınıf olarak belirleriz



#Tablona özel işlemleri DataAccess içinde yazman gerekir , tüm tablolarda standart olan işlemler , Core katmanı içindeki
DataAccess içinde tutulur



#ctor yazıp tab tab yaparsak constructor oluşturur



#Fonksiyonun içine comment yazılmaz



#Restful mimariler %99,9 JSON üzerinden ilerler



#IoC=Inversion Of Controller



#İçinde data tutmuyorsanız Singleton kullanılır



#AOP=Aspect Oriented Programming=Görünüşe Yönelik Programlama

ReSharper Kur Ve Kullanımını öğren



#Bir Manager içerisinde kendi DAL'ı hariç başka bir Dal enjeksiyonu yapamayız

FRONT-END



#Angular , Vue ve React DOM manipulasyonu yapmayı sağlar



#Component , HTML'in datasını yönettiğimiz yerdir



#JS'de süslü parantez{} demek obje demektir



#Yeni angular projesi kurmak için ng new northwind



#Bir bilgisayarda ilk defa angular projesi çalışılacaksa npm install -g @angular/cli



#Yeni bir component oluştururken ng g component component_name



#Angular projesini başlatmak için ng serve --open   



#Hedef klasör içinde bir service oluşturmak için : ng g service service_name



#Back-end porjemizde çalışma zinciri şöyle : Web Api -> Business -> DataAccess



#Cach'leme yöntemi genelde e-ticaret sitelerinde filtreleme fonksiyonlarında kullanılır ancak her şey de cache'lenmez
mesela 2-3 günde bir kullanılan ve büyük bir data döndüren bir fonksiyon cache'den döndürülmez sıkıntı yaratır



#Hedef klasör içinde bir pipe oluşturmak için : ng g pipe pipe_name



#Pipe'lar ile veri tabanına giden senaryolar yazmamaya çalışın , size gelen veriyi gösterirken değişiklikte bulunmak için
kullanın



#[] = kutu => Component.ts Html dosyasını etkiler 
() = muz. => Html dosyası Component.ts dosyasını etkiler
[()] = kutuda muz => İki yönlü binding yapar : Component.ts'den Html'e , Html'den Component'e etki yapar 



#Angular'da formlarla çalışırken Binding mekanizmasını kullanabilmek için app.module'e FormsModule'ı import etmek gerekir
Örnek : import { FormsModule } from '@angular/forms'



#npm install ngx-toastr
npm install @angular/animations



200 - "OK" (istek başarılı)
201 - "Created" (istek başarılı ve yeni bir kaynak oluşturuldu)
301 - "Moved Permanently" (istenilen kaynağın urlsi kalıcı olarak değiştirildi)
400 - "Bad Request" (client hatası olarak algılanan bir şey nedeniyle sunucu isteği işleyemiyor veya işlemeyecek)
401 - "Unauthorized" (client kimliğini doğrulanmamış.)
403 - "Forbidden" (client'ın içeriğe erişim hakkı yoktur, 401'den farkı sunucu client'ın kimliğini bilir)
404 - "Not Found" (Sunucu istenilen kaynağı bulamıyor)
500 - "Internal Server Error" (Sunucu istenmeyen türden bir durumla karşılaştı)
502 - "Bad Gateway" ( Bu hata, sunucu gereken yanıtı almak için getaway olarak çalışırken aldığı bir geçersiz yanıt durumunda oluşur.)

100-199 "Informational Responses"
200-299 "Successful Responses"
300-399 "Redirection Responses"
400-499 "Client Error Responses"
500-599 "Server Error Resonses"