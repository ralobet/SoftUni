<?php
if (isset($_GET['commands'])&&isset($_GET['delimiter']))
{
    $commands = $_GET['commands'];
    $delimiter = $_GET['delimiter'];

    $arr=explode("\n",$commands);
    $arr =array_map('trim',$arr);

    $result = [];

    for ($i=0;$i<count($arr);$i++)
    {
        $pairs = explode($delimiter,$arr[$i]);
        $command = $pairs[0];
        $value = $pairs[1];

        if ($command=='add')
        {
            array_push($result,$value);
        }
        else if($command=='remove')
        {
            array_splice($result,$value,1);
        }
    }

    for ($j=0;$j<count($result);$j++)
    {
        echo $result[$j].'<br>';
    }

}