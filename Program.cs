using System;

class PemrosesData {
    public T DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3) {
        dynamic N1 = (dynamic)nilai1;
        dynamic N2 = (dynamic)nilai2;
        dynamic N3 = (dynamic)nilai3;
        dynamic Terbesar = N1;

        if (N2 > Terbesar)
        {
            Terbesar = N2;
        }
        if (N3 > Terbesar)
        {
            Terbesar = N3;
        }

        return Terbesar;
    }

    //class simpleDataBase<T> {
    //    private List<T> storedData;
    //    private List<DateTime> inputData;

    //    public simpleDataBase(){
    //        storedData = new List<T>();
    //        inputData = new List<DateTime>();
    //    }

    //    public void addNewData(T) { 
            
    //    }
    //}

    class program {
        static void Main() {
            PemrosesData searching = new PemrosesData();
            Console.WriteLine("Nilai Terbesar Adalah: " + searching.DapatkanNilaiTerbesar(10.0, 30.5, 22.9));
        }
    }
}
