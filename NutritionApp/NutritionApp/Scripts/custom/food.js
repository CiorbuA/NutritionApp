var selectedFood;

function openFoodModal(food) {
    selectedFood = food;

    $('#food-name').text(food.Name);

    $('#myModal').modal();
}

function saveConsumtion() {
    var foodId = selectedFood.Id;
    var quantity = $('#quantity').val();

    $.post("/Home/SaveConsumtion", { foodId: foodId, quantity: quantity }, function (result) {
        $('#myModal').modal('hide');

        alert('Consumtion saved or maybe not (thinking)' + result);
    });

}


$(document).ready(function () {
    $('#quantity').change(function () {
        var quantity = $('#quantity').val();

        $('#fats-qt').text(selectedFood.Fats * quantity);
        $('#carbs-qt').text(selectedFood.Carbohydrates * quantity);
        $('#proteines-qt').text(selectedFood.Proteines * quantity);
        $('#kcal-qt').text(selectedFood.KCal * quantity);
    })
})




