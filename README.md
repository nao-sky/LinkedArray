# LinkedArray

environment
donet core 3.0 preview

test result

add method * 1000000
typename= List<decimal>
00:00:00.0359096
typename= LinkedArray<decimal>
00:00:00.0832229

incriment [index: 0-] * 100000
typename= List<decimal>
00:00:00.0034967
typename= LinkedArray<decimal>
00:00:00.0269421

insert1 [index: 0] * 100
typename= List<decimal>
00:00:00.1766647
typename= LinkedArray<decimal>
00:00:00.0137413

addrange [index: -] * 10000
typename= List<decimal>
00:00:01.9149752
typename= LinkedArray<decimal>
00:00:04.4149859

insert2 [index: * 9999] * 50
typename= List<decimal>
00:00:11.5318070
typename= LinkedArray<decimal>
00:00:00.0225997

remove [index: -] * 100
typename= List<decimal>
00:00:13.3656282
typename= LinkedArray<decimal>
00:00:00.0018530

removeat [index: 0] * 50
typename= List<decimal>
00:00:06.3458282
typename= LinkedArray<decimal>
00:00:00.0005130

insert range [index: +=20000] * 10
typename= List<decimal>
00:00:01.2780841
typename= LinkedArray<decimal>
00:00:00.0031791

clear method * 101000100
typename= List<decimal>
00:00:00.0006210
typename= LinkedArray<decimal>
00:00:00.0001870

add method * 1000000
typename= List<decimal>
00:00:00.0091142
typename= LinkedArray<decimal>
00:00:00.0753358

remove [index: -] * 100
typename= List<decimal>
00:00:00.1099219
typename= LinkedArray<decimal>
00:00:00.0004696

insert range [index: +=20000] * 10
typename= List<decimal>
00:00:00.0118003
typename= LinkedArray<decimal>
00:00:00.0095878

matched.
List time00:00:34.7838511
LinkedArray time00:00:04.6526172
