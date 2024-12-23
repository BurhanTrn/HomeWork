USE master
CREATE DATABASE OgrenciKulupleriYonetimi
USE OgrenciKulupleriYonetimi

CREATE TABLE Kulüpler
(
    KulupID INT PRIMARY KEY IDENTITY (1,1),
    KulupAdi NVARCHAR(70) NOT NULL,
    KurulusYili INT NOT NULL
)

CREATE TABLE OgrenciKulup
(
    OgrencıID INT PRIMARY KEY IDENTITY (1,1),
    Rol NVARCHAR(50) NOT NULL,
    KatilimTarihi DATE NOT NULL,
    KulupID INT,
    FOREIGN KEY (KulupID) REFERENCES Kulüpler(KulupID)
)

INSERT INTO Kulüpler
    (KulupAdi, KurulusYili)
VALUES
    ('Tiyatro Kulübü', 2010),
    ('Müzik Kulübü', 2012),
    ('Spor Kulübü', 2015),
    ('Bilim Kulübü', 2018),
    ('Sanat Kulübü', 2020);

INSERT INTO OgrenciKulup
    (KulupID, Rol, KatilimTarihi)
VALUES
    (1, 'Başkan', '2021-09-01'),
    (1, 'Üye', '2022-01-15'),
    (1, 'Sekreter', '2023-05-10'),

    (2, 'Başkan', '2020-10-01'),
    (2, 'Üye', '2021-02-20'),
    (2, 'Sekreter', '2022-11-15'),

    (3, 'Başkan', '2019-08-30'),
    (3, 'Üye', '2020-03-10'),
    (3, 'Sekreter', '2021-12-05'),

    (4, 'Başkan', '2022-05-01'),
    (4, 'Üye', '2022-09-15'),
    (4, 'Sekreter', '2023-01-20'),

    (5, 'Başkan', '2023-03-01'),
    (5, 'Üye', '2023-06-15'),
    (5, 'Sekreter', '2023-09-01');

--1.Sorgu
SELECT 
o.OgrencıID,k.KulupAdi
FROM Kulüpler k 
JOIN OgrenciKulup o ON k.KulupID = o.KulupID

--2.Sorgu 
SELECT 
 k.KulupAdi,o.OgrencıID,o.Rol
FROM Kulüpler k 
JOIN OgrenciKulup o 
ON k.KulupID = o.KulupID  
WHERE k.KulupAdi ='Tiyatro Kulübü';

--3.Sorgu
SELECT
    k.KulupAdi, o.OgrencıID, o.Rol
FROM Kulüpler k
    JOIN OgrenciKulup o
    ON k.KulupID = o.KulupID
WHERE o.Rol='Baskan';

--4.Sorgu
SELECT
KulupID, COUNT(*) AS [Üye Sayısı]
FROM OgrenciKulup 
GROUP BY KulupID 

--5.Sorgu
SELECT
    O.KulupID,
    K.KulupAdi,
    O.Rol,
    O.KatilimTarihi
FROM
    OgrenciKulup O
    JOIN
    Kulüpler K ON O.KulupID = K.KulupID
WHERE 
    K.KurulusYili = (SELECT MIN(KurulusYili)
FROM Kulüpler)
ORDER BY 
    O.KulupID;
    

--6.Sorgu
SELECT 
*
FROM OgrenciKulup o 
GROUP BY KulupID k
where 
