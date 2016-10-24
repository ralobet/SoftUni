<?php
if (isset($_GET['key-value-pairs'])&&isset($_GET['delimiter'])&&isset($_GET['target-key']))
{
    $keyValuePairs = $_GET['key-value-pairs'];
    $delimiter = $_GET['delimiter'];
    $targetKey = $_GET['target-key'];

    $arr=explode("\n",$keyValuePairs);
    $arr =array_map('trim',$arr);

    $result = [];

    for ($i=0;$i<count($arr);$i++)
    {
        $pairs = explode($delimiter,$arr[$i]);
        $key = $pairs[0];
        $value = $pairs[1];

        $result[$key]=$value;
    }

    if ($result[$targetKey]!=false)
    {
        echo $result[$targetKey];
    }
    else
    {
        echo 'None';
    }

}