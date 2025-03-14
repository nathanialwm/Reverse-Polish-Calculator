namespace ReversePolishCalculator {
     class Tokens {
        public enum TokenTypes {
            ADD, SUBTRACT, MULTIPLY, DIVIDE, EXP, // Operators
            LPAREN,
            RPAREN,
            NUMBER
        }

        public Tokens(TokenTypes type, char value, int precedence) {
            this.Type = type;
            this.Value = value;
            this.Precedence = precedence;
        }

        public Tokens(TokenTypes type, char value) {
            this.Type = type;
            this.Value = value;
        }

        public TokenTypes Type { get; set; }
        public char Value { get; set; }

        public int Precedence { get; set; }
    }
}