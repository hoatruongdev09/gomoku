public enum Player {
    Black = 1, White = 2
}

public static class PlayerFunction {
    public static Player GetOpponent (Player currentPlayer) {
        return currentPlayer == Player.Black?Player.White : Player.Black;
    }
}