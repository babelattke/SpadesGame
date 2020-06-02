cards.init({ table: '#mainboard', type: STANDARD });

//Create a new deck of cards
deck = new cards.Deck();

//By default it's in the middle of the container, put it slightly to the side
//deck.x -= 50;
deck.x -= 10;
deck.addCards(cards.all);
deck.render({ immediate: false });


// Bot1 => left || Bot 2 => Up || Bot 3 => Right || Player => Down
bot1 =		new cards.Hand({ faceUp: false, x: -60 });
bot2 =		new cards.Hand({ faceUp: false, y:  110});
bot3 =		new cards.Hand({ faceUp: false, x: 560 });
player =    new cards.Hand({ faceUp: true, y: 440 });

discardPile = new cards.Deck({ faceUp: true });
discardPile.x += 50;

//Let's deal when the Deal button is pressed:
$('#deal').click(function () {	
	$('#deal').hide();
	$('#imgLogo').hide();	
	document.getElementById("newGame").classList.remove("invisible");
	deck.deal(13, [bot1, bot2, bot3, player], 50, function () {	
		console.log("here: ");
		discardPile.addCard(deck.topCard());
		discardPile.render();
	});
});

deck.click(function (card) {
	if (card === deck.topCard()) {
		player.addCard(deck.topCard());
		player.render();
	}
});


player.click(function (card) {
	if (discardPile.length == 0) {
		discardPile.addCard(card);
		discardPile.render();
		player.render();
    } else if (card.suit == discardPile.topCard().suit
		|| card.rank == discardPile.topCard().rank) {
		discardPile.addCard(card);
		discardPile.render();
		player.render();
	}
});




$('#bidModal').on('click', '.btn-primary', function () {
	bid = $('#inlineRadio12').val();
	$('#hPlayerBid').val(bid);
	$("#bidModal").modal("hide");
});