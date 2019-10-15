# To-Do-List-Application
To-Do List Application For Huawei

UI katmanından api çağırarak projeyi yapmayı hedefledim. Söz konusu UI(WPF) için zamanım yetmedi. Unit testi de projeyi göndermeden önce son anda yazmaya çalışma fırsatım oldu.

Teknik ön bilgiler;

Uygulama Visual Studio 2019 da geliştirildi.

ToDoListApp Solution'ının için 7 proje var. Bunlar;
1- Entities - Class Library (.Net Standard) - (Entity'lerin olduğu katman)
2- DataAccess - Class Library (.Net Standard) - (Veritabanı işlemleri)
3- Business - Class Library (.Net Standard) - (İş kuralları)
4- Core - Class Library (.Net Standard) - (Bağımsız ortak katman)
5- WebAPI - ASP.NET Core 3.0 - (API)
6- WPF - .NET Core 3.0 
7- Business.Tests - .NET Framework 4.7.2 - (Testlerin olduğu katman)

Tüm geliştirme ortamlarında kullanılabilmesi için Class Library (.Net Standard)

Dependency Injection Autofac ile yapıldı.

Database'i WebAPI'de code first ile oluşturdum. Uygulamayı bir defaya mahsus WebAPI'den başlatırsanız "ToDoListApp" isminde bir database tabloları ile birlikte oluşmuş olur.



