<?php
if (isset($_GET['key-value-pairs'])&&isset($_GET['delimiter'])&&isset($_GET['target-key']))
{
    $keyValuePairs = $_GET['key-value-pairs'];
    $delimiter = $_GET['delimiter'];
    $targetKey = $_GET['target-key'];

    $arr=explode("\n",$keyValuePairs);
    $arr =array_map('trim',$arr);


    $keys = [];
    $values =[];
    $result=[];

    for ($i=0;$i<count($arr);$i++)
    {
        $pairs = explode($delimiter,$arr[$i]);
        $key = $pairs[0];
        $value = $pairs[1];

        array_push($keys,$key);
        array_push($values,$value);

    }

    if (in_array($targetKey, $keys))
    {
        for ($j=0;$j<count($keys);$j++)
        {
            if ($keys[$j]==$targetKey)
            {
               array_push($result,$values[$j]);
            }

        }
        echo implode("<br>",$result);
    }
    else
    {
        echo 'None';
    }


}