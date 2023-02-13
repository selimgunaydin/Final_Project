let data = fetch("https://finans.truncgil.com/today.json")
.then(response=>response.json())
.then(veri=>{
$(".usd").html(veri["USD"].Alış + "₺");
$(".eur").html(veri["EUR"].Alış + "₺");
$(".gram-altin").html(veri["gram-altin"].Alış + "₺");
$(".ons").html(veri["ons"].Alış+"₺");
});