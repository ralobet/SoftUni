<?php
if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {

    $num1 = intval($_GET['num1']);
    $num2 = intval($_GET['num2']);
    $num3 = intval($_GET['num3']);

    $isZero = false;
    $counterr = 0;

    if ($num1 == 0 || $num2 == 0 || $num3 == 0) {
        $isZero = true;
    }
    if ($num1 < 0) {
        $counterr++;
    }
    if ($num2 < 0) {
        $counterr++;
    }
    if ($num3 < 0) {
        $counterr++;
    }
    if ($counterr % 2 != 0 && !$isZero)
    {
        echo "Negative";
    }
    else
    {
        echo "Positive";
    }
}
?>