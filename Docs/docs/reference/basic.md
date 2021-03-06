#基本事項

## コメント
プログラムには自由にコメントを入れることができます。
コメントは空白と同じ扱いになります。

コメントには`#`から改行文字までの単一行コメント
```
# 単一行コメント
```
と、`#[`から`#]`までの複数行コメント
```
#[
複数行コメント
#]
```
があります。

複数行コメントの開始記号を単一行コメントでコメントアウトすると、
以下のように複数行コメントを一時的に無効にできます。
```
##[
ここはコメントではない
#]
```

## 識別子
変数名、関数名、仮引数名、ユーザ定義の型名、ユーザ定義のタグなどの名前を
識別子とよびます。
識別子はアルファベット、数字、アンダースコアの列です。
ただし、一文字目はアルファベットまたはアンダースコアである必要があります。
さらに、キーワードと同じ文字列は利用することはできません。

## キーワード
以下の文字列はキーワードとして予約されており、
識別子として利用することはできません。

`and` `as` `call` `cast` `delegate` `do` `else` `end`
`false` `for` `fun` `get` `if` `import` `in` `include`
`let` `new` `pat` `set` `sget` `sset` `true` `type`
`using` `__define` `__prim` `__undefine`

## プログラムの構成
Mokkosu のプログラムは文の列として表現されます。
文はソースファイルの上から順番に評価されていきます。
