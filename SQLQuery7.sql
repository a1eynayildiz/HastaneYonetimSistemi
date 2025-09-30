CREATE PROCEDURE guncelle
    @id int,
    @ad varchar(50),
    @soyad varchar(50),
    @tc char(11),
    @tel char(11),
    @yas smallint,
    @cins varchar(50),
    @sikayet varchar(200),
    @tarih date,
    @durum int,
    @bolum int,
    @ex bit
AS
BEGIN
    UPDATE tbl_HastaBilgi SET hAd = @ad, hSoyad = @soyad, hTc = @tc, hTel = @tel, hYas = @yas, hCinsiyet = @cins, hSikayet= @sikayet, 
    kTarih = @tarih,hDurum = @durum, hBolum = @bolum, hExMi = @ex where ID = @id
END