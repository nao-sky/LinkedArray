# LinkedArray

environment
donet core 3.0 preview

test result

add method * 1000000
typename= List<decimal>
00:00:00.0481926
typename= LinkedArray<decimal>
00:00:00.0954553

incriment [index: 0-] * 100000
typename= List<decimal>
00:00:00.0029064
typename= LinkedArray<decimal>
00:00:00.0238247

insert1 [index: 0] * 100
typename= List<decimal>
00:00:00.1816066
typename= LinkedArray<decimal>
00:00:00.0130261

addrange [index: -] * 10000
typename= List<decimal>
00:00:02.1003748
typename= LinkedArray<decimal>
00:00:04.6126752

insert2 [index: * 9999] * 50
typename= List<decimal>
00:00:08.4554171
typename= LinkedArray<decimal>
00:00:00.0179342

remove [index: -] * 100
typename= List<decimal>
00:00:13.2354776
typename= LinkedArray<decimal>
00:00:00.0167936

removeat [index: 0] * 50
typename= List<decimal>
00:00:06.6802373
typename= LinkedArray<decimal>
00:00:00.0005253

insert range [index: +=20000] * 10
typename= List<decimal>
00:00:01.3105346
typename= LinkedArray<decimal>
00:00:00.0030239

clear method * 101000100
typename= List<decimal>
00:00:00.0005216
typename= LinkedArray<decimal>
00:00:00.0002000

add method * 1000000
typename= List<decimal>
00:00:00.0093255
typename= LinkedArray<decimal>
00:00:00.0757735

remove [index: -] * 100
typename= List<decimal>
00:00:00.1295495
typename= LinkedArray<decimal>
00:00:00.0008662

insert range [index: +=20000] * 10
typename= List<decimal>
00:00:00.1120530
typename= LinkedArray<decimal>
00:00:00.0047375

matched.
List time00:00:32.2661966
LinkedArray time00:00:04.8648355
