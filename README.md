# Labyrinth of Refrain: Coven of Dusk [steam] Save data Editor
ルフランのセーブエディタです。  
と言ってもチートするというよりデータがおかしくなったセーブデータを修復するために作りました。
  
![Refrain](https://user-images.githubusercontent.com/50650451/82120815-bcca1a80-97c3-11ea-8f4f-9381f5214b5b.png)
  
いろいろやっているうちに何かいろいろできるようになりました。  
いろいろできるといっても、この手のものはやりすぎるとつまらなくなるので注意です。  
  
キャラの絵を別に設定できるようになったので、ファセット変えてもキャラの絵を固定できます（これが欲しかった）   

バイナリの配布はしませんので、ソースをcloneしてビルドしてください。 
  
# 出来る事
* 銀貨/Mana/カルマの編集
* キャラクタの因果数・経験値・トータル経験値・アニマクラリティ・Level・総Level・その他の編集
* キャラクタのSkillの編集。
  
パラメータの最大値とかのチェックをしてないので、不正な値を入れるとバグります。  
 

# RefrainCTE
同梱されているRefrainCTEはCheat EngineのCTファイルを作成するものです。  
ルフランは実行する度に内部アドレス位置が変わってしまうので、そのたびに走査するのが面倒なので作ったものです。  
一番走査が楽なリーンフォースのアドレス位置だけ調べて、その他の必要な項目のアドレスを計算します。
ExportでCTファイルを出力です。  
  
後、キャラクタのHPのアドレスをサーチしてそれを入力することで、他のパラメータのアドレスも計算してCTファイルにエキスポートできるようになりました。  


## Dependency
Visual studio 2017 C#

## License
This software is released under the MIT License, see LICENSE

## Authors

bry-ful(Hiroshi Furuhashi) http://bryful.yuzu.bz/  
twitter:[bryful](https://twitter.com/bryful)  
bryful@gmail.com  

## References
