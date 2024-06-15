Mail gönderme bölümlerine kendi mailinizi(outlook) ve şifrenizi girerek mail gönderme işlemlerini kontrol edebilirsiniz.
----------------------------------
Hub.resx dosyası ile ilgili bir sorun alırsanız dosyaya sağ tıklayarak özelliklere girip en alt kısımda engellemeyi kaldır diyebilirsiniz.
----------------------------------
Hub.cs ekranında herhangi bir tasarım değiştirmeniz durumunda karşılaşabileceğiniz sorunu ;

this.phonebook_form1 = new "Hub."phonebook_form();
this.pı1 = new Hub.PI();
this.notesForm1 = new "Hub."notesForm();
this.managementForm = new "Hub."managementcontrolform();
this.salarycalculaterform1 = new "Hub."salarycalculaterform();

Hata açıklaması bölümünden hataya erişip Hub.Designer.cs dosyasında sorun yaratan bölümde

"Hub." bölümlerini silerek sorunu giderebilirsiniz.
-----------------------------------
