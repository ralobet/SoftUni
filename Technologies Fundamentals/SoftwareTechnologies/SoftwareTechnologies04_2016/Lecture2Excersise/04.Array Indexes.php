<?php
if (isset($_GET['key-value-pairs'])&&isset($_GET['delimiter'])&&isset($_GET['array-size']))
{
    $lines = $_GET['key-value-pairs'];

    $delimiter = $_GET['delimiter'];
    $arraySize = $_GET['array-size'];

    $arrOfKeyValue = new SplFixedArray($arraySize);
    $arrOfKeyValue = explode("\n",$lines);
    $arrOfKeyValue = array_map('trim',$arrOfKeyValue);

    $result = [];
    $pairs = [];

    for ($k=0;$k<$arraySize;$k++)
    {
        $result[$k]=0;
    }

    for ($i=0;$i<count($arrOfKeyValue);$i++)
    {

        $pairs = explode($delimiter,$arrOfKeyValue[$i]);
        $key = intval($pairs[0]) ;
        $value = intval($pairs[1]);

        $result[$key]=$value;

    }
    for($j=0;$j<count($result);$j++)
    {
        echo $result[$j].'<br>';
    }
}