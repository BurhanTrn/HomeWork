USE master
CREATE DATABASE PersonelMaasYonetimi
USE PersonelMaasYonetimi

CREATE TABLE Personel
(
    PersonelID INT PRIMARY KEY IDENTITY (1,1),
    PersonelAd NVARCHAR(50) NOT NULL,
    PersonelSoyad NVARCHAR(50) NOT NULL,
    Pozisyon NVARCHAR(70) NOT NULL,
    BaslangicTarihi DATE NOT NULL

)

CREATE TABLE Maaslar
(
    MaasID INT PRIMARY KEY IDENTITY (1,1),
    MaasMiktari DECIMAL(10,2) NOT NULL,
    GuncellemeTarihi DATE NOT NULL,
    PersonelID INT,
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
)
INSERT INTO Personel
    ( PersonelAd, PersonelSoyad, Pozisyon, BaslangicTarihi)
VALUES
    ('Ahmet', 'Yılmaz', 'Okul Müdürü', '2020-01-15'),
    ('Ayşe', 'Demir', 'Matematik Öğretmeni', '2019-09-01'),
    ( 'Mehmet', 'Çelik', 'Fen Bilgisi Öğretmeni', '2021-08-25'),
    ( 'Fatma', 'Aydın', 'Tarih Öğretmeni', '2022-02-10'),
    ('Ali', 'Korkmaz', 'İngilizce Öğretmeni', '2021-03-20'),
    ( 'Elif', 'Arslan', 'Sekreter', '2018-11-12'),
    ('Oğuz', 'Kaya', 'Beden Eğitimi Öğretmeni', '2023-05-15'),
    ( 'Zeynep', 'Tekin', 'Rehber Öğretmen', '2020-10-01'),
    ( 'Serkan', 'Polat', 'Bilgisayar Öğretmeni', '2022-04-05'),
    ( 'Ceren', 'Sönmez', 'Sanat Öğretmeni', '2019-12-20');

INSERT INTO Maaslar
    ( PersonelID, MaasMiktari, GuncellemeTarihi)
VALUES
    ( 1, 10000, '2020-01-15'),
    ( 1, 11000, '2021-01-15'),
    (2, 8000, '2019-09-01'),
    ( 2, 8500, '2020-09-01'),
    ( 3, 9000, '2021-08-25'),
    ( 3, 9500, '2022-08-25'),
    ( 4, 7500, '2022-02-10'),
    ( 4, 7800, '2023-02-10'),
    ( 5, 8500, '2021-03-20'),
    ( 5, 8800, '2022-03-20'),
    ( 6, 6000, '2018-11-12'),
    ( 6, 6200, '2019-11-12'),
    ( 7, 7000, '2023-05-15'),
    ( 8, 7200, '2020-10-01'),
    ( 9, 9500, '2022-04-05'),
    ( 10, 8000, '2019-12-20'),
    ( 10, 8200, '2020-12-20');



 