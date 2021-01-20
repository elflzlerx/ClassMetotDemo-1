class Musteri{
    private int id;
    private string  ad;
    private string soyad;

    public Musteri(){

    }
    public Musteri(int id, string ad, string soyad){
        this.id = id;
        this.ad = ad;
        this.soyad = soyad;
    }

    public int ID{
        get{return id;}
    }
    public string Ad{
        get{return ad;}
    }
    public string Soyad{
        get{return soyad;}
    }
}