namespace FormsGyumolcs {
    internal class Vegetable {

        public readonly int Id;
        public readonly string Name;
        public readonly int Egysegar;
        public readonly int Mennyiseg;

        public Vegetable(int id, string name, int egysegar, int mennyiseg) {
            Id = id;
            Name = name;
            Egysegar = egysegar;
            Mennyiseg = mennyiseg;
        }

        public override string ToString() {
            return Name;
        }
    }
}