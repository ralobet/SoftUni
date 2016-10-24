<?php
if (isset($_GET['commands'])&&isset($_GET['date'])&&isset($_GET['format']))
{
    $lines = $_GET['commands'];
    $string=$_GET['date'];
    $str = "$string";
    $date = DateTime::createFromFormat('d/m/Y', $str);

    $format=$_GET['format'];

    $commands = explode(" ",$lines);
    $command = $commands[0];
    $dateSpan = $commands[1];

    if ($command=='add')
    {
        $string = '+'.$dateSpan." ".'day';
        $date=$date->modify($string);

    }
    else
    {
        $string = '-'.$dateSpan." ".'day';
        $date=$date->modify($string);

    }
    echo $date->format($format);


}
