# Emmanuel_Custodio_tarea_1
Este programa calcula el Impuesto sobre la Renta (IRS) en República Dominicana basado en el sueldo ingresado por el usuario.
su funcionamiento consta de pedirle los datos al usuario "el sueldo".
luego el programa aplica los calculos del impuesto y dictan si cae en  la escala impositiva dominicana con 4 rangos:

Primer rango: Sueldos ≤ $416,220 → No pagan IRS (N/A)
Segundo rango: $416,221 - $624,329 → Paga el 15% del excedente sobre $416,220
Tercer rango: $624,330 - $867,123 → Paga $31,216 + 20% del excedente sobre $624,329
Cuarto rango: Sueldos > $867,123 → Paga $79,776 + 25% del excedente sobre $867,123

por ultimo el programa muestra el sueldo ingresado y el monto del IRS calculado.
aqui las formulas aplicadas:
Rango 2: IRS = (Sueldo - 416,220) × 0.15
Rango 3: IRS = 31,216 + [(Sueldo - 624,329) × 0.20]
Rango 4: IRS = 79,776 + [(Sueldo - 867,123) × 0.25]

funcionamiento del programa.

primer caso.

segundo caso.

tercer caso.

cuarto caso.
