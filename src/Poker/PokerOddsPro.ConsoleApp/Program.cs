using PokerOddsPro.OddsEngine.Dto;
using PokerOddsPro.Shared.Dto.PokerDto.General;
using PokerOddsPro.Shared.Services;
using PokerOddsPro.Shared.ViewModels;

namespace PokerConsoleApp;

// https://github.com/dyh1213/PokerOddsPro

class Program
{
    // PokerOddsPro.Shared/Pages/Index.razor
    private static HoldemCardGameManager _cardGameController { get; set; }
    //private static int PlayerCount => _cardGameController.Players.Count();

    static async Task Main(string[] args)
    {
        Console.WriteLine("♥♣♦♠");

        await CalculateOdds();

        Console.WriteLine("Press <Enter> to close");
        Console.ReadLine();
    }

    // PokerOddsPro.Shared/Pages/Index.razor
    //Task AddPlayer() => await _cardGameController.AddPlayer();
    //Task RemovePlayer(PlayerController player) => await _cardGameController.RemovePlayer(player);

    // PokerOddsPro.Shared/Components/CardSelectionPanel.razor
    //private async Task SetSelectedCard(Card CardInfo) => await _cardGameController.SetSelectedCard(CardInfo);

    static async Task CalculateOdds()
    {

        // PokerOddsPro.Shared/Pages/Index.razor
        _cardGameController = new HoldemCardGameManager(numberOfPlayers: 2, minimumBoardCards: 2);

        // Print all cards to get details for below.
        //var cards = Helper.GetAllCards();
        //cards.ForEach(Console.WriteLine);

        // PokerOddsPro.Shared/Components/CardSelectionPanel.razor
        // SetSelectedCard

        //CardSlot cardSlot;
        //cardSlot.SelectCardSlot();

        //SetCardsAttempt1();
        //SetCardsAttempt2();
        //SetCardsAttempt3();
        SetCardsAttempt4();

        PrintCards();

        await _cardGameController.CalculateOdds();

        DisplayResults();
    }

    #region Test

    // ♥♣♦♠
    static void SetCardsAttempt4()
    {
        // Player 1
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 0, 0, 0, CardNumberEnum.King, CardSuitEnum.Club); // K♣
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 0, 1, 0, CardNumberEnum.King, CardSuitEnum.Diamond); // K♦

        // Player 2
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 1, 0, 0, CardNumberEnum.Seven, CardSuitEnum.Diamond); // 7♦
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 1, 1, 0, CardNumberEnum.Eight, CardSuitEnum.Heart); // 8♥

        // Board
        SetCard(CardSlotTypeEnum.BoardCardSlot, 0, -1, 0, CardNumberEnum.Six, CardSuitEnum.Club); // 6♣
        SetCard(CardSlotTypeEnum.BoardCardSlot, 1, -1, 0, CardNumberEnum.Nine, CardSuitEnum.Spade); // 9♠
        SetCard(CardSlotTypeEnum.BoardCardSlot, 2, -1, 0, CardNumberEnum.Ten, CardSuitEnum.Spade); // 10♠
        //SetCard(CardSlotTypeEnum.BoardCardSlot, 3, -1, 0, CardNumberEnum., CardSuitEnum.); // 
        //SetCard(CardSlotTypeEnum.BoardCardSlot, 4, -1, 0, CardNumberEnum., CardSuitEnum.); // 

        // Dead Cards
        // Player 3
        SetCard(CardSlotTypeEnum.DeadCardSlot, 0, 0, 0, CardNumberEnum.King, CardSuitEnum.Heart); // K♥
        SetCard(CardSlotTypeEnum.DeadCardSlot, 1, 1, 0, CardNumberEnum.Jack, CardSuitEnum.Spade); // J♠
    }

    static void SetCardsAttempt3()
    {
        // Player 1
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 0, 0, 1, CardNumberEnum.Two, CardSuitEnum.Club); // 2♣
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 0, 1, 2, CardNumberEnum.Three, CardSuitEnum.Club); // 3♣

        // Player 2
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 1, 0, 27, CardNumberEnum.Two, CardSuitEnum.Heart); // 2♥
        SetCard(CardSlotTypeEnum.PlayerCardSlot, 1, 1, 28, CardNumberEnum.Three, CardSuitEnum.Heart); // 3♥

        // Board
        SetCard(CardSlotTypeEnum.BoardCardSlot, 0, -1, 42, CardNumberEnum.Four, CardSuitEnum.Spade); // 4♠
        SetCard(CardSlotTypeEnum.BoardCardSlot, 1, -1, 43, CardNumberEnum.Five, CardSuitEnum.Spade); // 5♠
        SetCard(CardSlotTypeEnum.BoardCardSlot, 2, -1, 44, CardNumberEnum.Six, CardSuitEnum.Spade); // 6♠
        //SetCard(CardSlotTypeEnum.BoardCardSlot, 3, -1, 45, CardNumberEnum.Seven, CardSuitEnum.Spade); // 7♠
        //SetCard(CardSlotTypeEnum.BoardCardSlot, 4, -1, 46, CardNumberEnum.Eight, CardSuitEnum.Spade); // 8♠
    }

    static void SetCardsAttempt2()
    {
        // Player 1
        CardInfo cardInfo1 = new CardInfo() { CardId = 1, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Club }; // 2♣
        Card card1 = new Card() { IsAvailable = false, CardInfo = cardInfo1 };
        CardSlot cardSlot1 = new CardSlot() { Card = card1, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.PlayerCardSlot };
        _cardGameController.Players[0].Cards[0] = cardSlot1;

        CardInfo cardInfo2 = new CardInfo() { CardId = 2, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Club }; // 3♣
        Card card2 = new Card() { IsAvailable = false, CardInfo = cardInfo2 };
        CardSlot cardSlot2 = new CardSlot() { Card = card2, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.PlayerCardSlot };
        _cardGameController.Players[0].Cards[1] = cardSlot2;

        // Player 2
        CardInfo cardInfo3 = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart }; // 2♥
        Card card3 = new Card() { IsAvailable = false, CardInfo = cardInfo3 };
        CardSlot cardSlot3 = new CardSlot() { Card = card3, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.PlayerCardSlot };
        _cardGameController.Players[1].Cards[0] = cardSlot3;

        CardInfo cardInfo4 = new CardInfo() { CardId = 28, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Heart }; // 3♥
        Card card4 = new Card() { IsAvailable = false, CardInfo = cardInfo4 };
        CardSlot cardSlot4 = new CardSlot() { Card = card4, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.PlayerCardSlot };
        _cardGameController.Players[1].Cards[1] = cardSlot4;

        // Board
        CardInfo cardInfoBoardFlop1 = new CardInfo() { CardId = 42, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Spade }; // 4♠
        Card cardFlop1 = new Card() { IsAvailable = false, CardInfo = cardInfoBoardFlop1 };
        CardSlot cardSlotFlop1 = new CardSlot() { Card = cardFlop1, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.BoardCardSlot };
        _cardGameController.BoardCardSlots[0] = cardSlotFlop1;

        CardInfo cardInfoBoardFlop2 = new CardInfo() { CardId = 43, CardNumber = CardNumberEnum.Four, CardSuit = CardSuitEnum.Spade }; // 5♠
        Card cardFlop2 = new Card() { IsAvailable = false, CardInfo = cardInfoBoardFlop2 };
        CardSlot cardSlotFlop2 = new CardSlot() { Card = cardFlop2, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.BoardCardSlot };
        _cardGameController.BoardCardSlots[1] = cardSlotFlop2;

        CardInfo cardInfoBoardFlop3 = new CardInfo() { CardId = 44, CardNumber = CardNumberEnum.Six, CardSuit = CardSuitEnum.Spade }; // 6♠
        Card cardFlop3 = new Card() { IsAvailable = false, CardInfo = cardInfoBoardFlop3 };
        CardSlot cardSlotFlop3 = new CardSlot() { Card = cardFlop3, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.BoardCardSlot };
        _cardGameController.BoardCardSlots[2] = cardSlotFlop3;

        //CardInfo cardInfoBoardTurn = new CardInfo() { CardId = 28, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Heart }; // 3♥
        //Card cardTurn = new Card() { IsAvailable = false, CardInfo = cardInfoBoardTurn };
        //CardSlot cardSlotTurn = new CardSlot() { Card = cardTurn, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.BoardCardSlot };
        //_cardGameController.BoardCardSlots[3] = cardSlotTurn;

        //CardInfo cardInfoBoardRiver = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart }; // 2♥
        //Card cardRiver = new Card() { IsAvailable = false, CardInfo = cardInfoBoardRiver };
        //CardSlot cardSlotRiver = new CardSlot() { Card = cardRiver, CardSlotType = PokerOddsPro.Shared.Dto.PokerDto.General.CardSlotTypeEnum.BoardCardSlot };
        //_cardGameController.BoardCardSlots[4] = cardSlotRiver;
    }

    static async Task SetCardsAttempt1()
    {
        // Set the first card of the first player as selected??
        _cardGameController.Players.FirstOrDefault().Cards.FirstOrDefault().SelectCardSlot();
        var cardSlot = _cardGameController.Players.FirstOrDefault().Cards.FirstOrDefault();
        _cardGameController.UpdateSelectedCard(cardSlot);

        // ♥♣♦♠
        // Player 1
        Card card1 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 1, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Club } }; // 2♣
        await _cardGameController.SetSelectedCard(card1);
        PrintCards(true, false);

        Card card2 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 2, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Club } }; // 3♣
        await _cardGameController.SetSelectedCard(card2);
        PrintCards(true, false);

        // Player 2
        Card card3 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        await _cardGameController.SetSelectedCard(card3);
        PrintCards(true, false);

        Card card4 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 28, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Heart } }; // 3♥
        await _cardGameController.SetSelectedCard(card4);
        PrintCards(true, false);

        // Board
        Card flop1 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 42, CardNumber = CardNumberEnum.Four, CardSuit = CardSuitEnum.Spade } }; // 4♠
        await _cardGameController.SetSelectedCard(flop1);
        PrintCards(false, true);

        Card flop2 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 43, CardNumber = CardNumberEnum.Five, CardSuit = CardSuitEnum.Spade } }; // 5♠
        await _cardGameController.SetSelectedCard(flop2);
        PrintCards(false, true);

        Card flop3 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 44, CardNumber = CardNumberEnum.Six, CardSuit = CardSuitEnum.Spade } }; // 6♠
        await _cardGameController.SetSelectedCard(flop3);
        PrintCards(false, true);

        //Card turn = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        //await _cardGameController.SetSelectedCard(turn);
        //PrintCards(false, true);

        //Card river = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        //await _cardGameController.SetSelectedCard(river);
        //PrintCards(false, true);

        //PrintCards();
    }

    #endregion Test

    #region Helpers

    static void SetCard(CardSlotTypeEnum cardSlotType, int position, int cardPosition, int cardId, CardNumberEnum cardNumber, CardSuitEnum cardSuit)
    {
        CardInfo cardInfo = new CardInfo() { CardId = cardId, CardNumber = cardNumber, CardSuit = cardSuit };
        Card card = new Card() { IsAvailable = false, CardInfo = cardInfo };
        CardSlot cardSlot = new CardSlot() { Card = card, CardSlotType = cardSlotType };

        switch (cardSlotType)
        {
            case CardSlotTypeEnum.BoardCardSlot:
                _cardGameController.BoardCardSlots[position] = cardSlot;
                break;
            case CardSlotTypeEnum.PlayerCardSlot:
                _cardGameController.Players[position].Cards[cardPosition] = cardSlot;
                break;
            case CardSlotTypeEnum.DeadCardSlot:
                _cardGameController.DeadCardsSlots[position] = cardSlot;
                break;
        }
    }

    static void PrintCards(bool players = true, bool board = true, bool dead = true)
    {
        if (players) PrintPlayersCards();
        if (board) PrintBoardCards();
        if (dead) PrintDeadCards();
    }

    static void PrintPlayersCards()
    {
        Console.WriteLine("Player's cards:");
        _cardGameController.Players.ForEach(p =>
        {
            p.Cards.ForEach(c => Console.WriteLine(c.Card));
        });
    }

    static void PrintBoardCards()
    {
        Console.WriteLine("Board cards:");
        _cardGameController.BoardCardSlots.ForEach(cs => Console.WriteLine(cs.Card));
    }

    static void PrintDeadCards()
    {
        Console.WriteLine("Dead cards:");
        _cardGameController.DeadCardsSlots.ForEach(cs => Console.WriteLine(cs.Card));
    }

    static void DisplayResults()
    {
        Console.WriteLine("%s");
        
        _cardGameController.Players.ForEach(p =>
        {
            //var results = $"🟢{p.WinPercentage} 🔴{p.LoosePercentage} 🟠{p.TiePercentage}";
            var results = $"{GetPercentageDisplay(p.WinPercentage)} {GetPercentageDisplay(p.LoosePercentage)} {GetPercentageDisplay(p.TiePercentage)}";
            Console.WriteLine(results);
        });
    }

    // PokerOddsPro.Shared/Components/PlayerDisplay.razor
    private static string GetPercentageDisplay(double value) => (value > 0) ? value.ToString("P1") : "-";

    #endregion Helpers
}