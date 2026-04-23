CREATE PROCEDURE girisYap
    @kulAdi varchar(50),
    @sifre varchar(50)
AS
BEGIN
    SELECT * FROM tbl_Login where kulAdi = @kulAdi and sifre = @sifre
    INSERT INTO tbl_Login (kulAdi, sifre)
    VALUES (@kulAdi, @sifre);
END

SELECT * FROM tbl_Login