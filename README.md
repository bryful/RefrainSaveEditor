# Labyrinth of Refrain: Coven of Dusk [steam] Save data Editor
ルフランのセーブエディタです。  
と言ってもチートするというよりデータがおかしくなったセーブデータを修復するために作りました。
  
バイナリの配布はしませんので、ソースをcloneしてビルドしてください。 
  
# 出来る事
* 銀貨/Mana/カルマの編集
* キャラクタの因果数・経験値・トータル経験値・アニマクラリティ・Level・総Levelの編集
* キャラクタのSkillの編集。
 

# RefrainCTE
同梱されているRefrainCTEはCheat EngineのCTファイルを作成するものです。  
ルフランは実行する度に内部アドレス位置が変わってしまうので、そのたびに走査するのが面倒なので作ったものです。  
一番走査が楽なリーンフォースのアドレス位置だけ調べて、その他の必要な項目のアドレスを計算します。
ExportでCTファイルを出力です。


## Dependency
Visual studio 2017 C#

## License
This software is released under the MIT License, see LICENSE

## Authors

bry-ful(Hiroshi Furuhashi) http://bryful.yuzu.bz/  
twitter:[bryful](https://twitter.com/bryful)  
bryful@gmail.com  

## References
