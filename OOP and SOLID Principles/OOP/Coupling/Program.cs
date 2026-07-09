using Coupling;

var order = new Order(new SmsSender());
order.PlaceOrder();