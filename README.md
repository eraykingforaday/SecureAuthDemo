# SecureAuthDemo

Bu proje, ASP.NET Core kullanarak JWT (JSON Web Tokens) ile güvenli bir kimlik doğrulama sistemi sağlar.

## Başlarken

Proje bağımlılıklarını yüklemek için aşağıdaki komutları çalıştırın:

```bash
dotnet restore
```

Projeyi başlatmak için:

```bash
dotnet run
```

## Yapılandırma

JWT ayarlarını `appsettings.json` dosyasından yapabilirsiniz:

```json
{
  "Jwt": {
    "Key": "superSecretKey@345",
    "Issuer": "http://localhost:5000",
    "Audience": "http://localhost:5000"
  }
}
```

## API Uç Noktaları

### Kimlik Doğrulama

- `POST /auth/login`: Kullanıcı girişi yaparak JWT token alır.

### Korunan Uç Nokta

- `GET /secure`: JWT ile korunan bir uç nokta.

## Kullanım

JWT token oluşturduktan sonra korunan uç noktalara erişmek için aşağıdaki gibi bir `Authorization` header ekleyin:

```
Authorization: Bearer YOUR_JWT_TOKEN
```