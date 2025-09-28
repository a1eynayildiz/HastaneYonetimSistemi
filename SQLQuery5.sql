create procedure kaydet
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
as
begin
insert into tbl_HastaBilgi(hAd,hSoyad,hTc,hTel,hYas,hCinsiyet,hSikayet,kTarih,hDurum,hBolum,hExMi)
values(@ad,@soyad,@tc,@tel,@yas,@cins,@sikayet,@tarih,@durum,@bolum,@ex)
end