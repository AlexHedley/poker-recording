using Microsoft.AspNetCore.Components;

using PokerOddsPro.Shared.Dto.PokerDto.General;
using PokerOddsPro.Shared.Dto;
using PokerOddsPro.Shared.Services;
using PokerOddsPro.Shared.ViewModels;

namespace PokerOddsPro.WebAssembly.Components;
public partial class CardBoard
{

    [Parameter]
    public BrowserWindowSizeContainer browserSize { get; set; }

    [Parameter]
    public BaseBoardDetails BoardDetails { get; set; }

    [Parameter]
    public List<CardSlot> Cards { get; set; }

    [Parameter]
    public EventCallback<CardSlot> UpdateSelectedCard { get; set; }

    public double majorMarginRight = 0.05;
    public double minorMarginRight = 0.025;
    public double computedWidthPercentage => ((1 - (majorMarginRight * 2 + minorMarginRight * 2)) / 5);

    //todo FIX PROPORTION ISSUES
    private CardDisplayTypeEnum cardDisplayType => (!browserSize.IsMobileProportion) ? CardDisplayTypeEnum.Classic : CardDisplayTypeEnum.Modern;

    public double GetMarginByCardIndex(int index)
    {
        if (BoardDetails.IsLastCardInAnyStreet(index + 1))
        {
            if (BoardDetails.NumberOfBoardCards == index + 1)
            {
                return 0;
            }
            else
            {
                return majorMarginRight;
            }
        }

        return minorMarginRight;
    }

    public string GetCssForCard(int index)
    {
        return $"margin-right:{GetMarginByCardIndex(index).ToString("P").Replace(" ", "")}; width:{computedWidthPercentage.ToString("P").Replace(" ", "")}; float:left;";
    }
}
