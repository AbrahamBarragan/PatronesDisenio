using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoTC2 = new PagoTarjetaDebito("9024");
Ventas ventaTC2 = new Ventas(pagoTC2);
ventaTC2.ProcesarPago();

IPago pagoM = new PagoMonedero();
Ventas ventaM = new Ventas(pagoM);
ventaM.ProcesarPago();

IPago pagoC = new PagoCheque();
Ventas ventaC = new Ventas(pagoC);
ventaC.ProcesarPago();

IPago pagoC2 = new PagoEfectivo();
Ventas ventaC2 = new Ventas(pagoC2);
ventaC2.ProcesarPago();

IPago pagoP = new PagoPaypal();
Ventas ventaP = new Ventas(pagoP);
ventaP.ProcesarPago();