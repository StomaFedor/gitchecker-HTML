using Aspose.Html;

var document = new HTMLDocument();

var h2 = (HTMLHeadingElement)document.CreateElement("h2");
var text = document.CreateTextNode("gitchecker");
h2.AppendChild(text);
document.Body.AppendChild(h2);

var p = (HTMLParagraphElement)document.CreateElement("p");
var data = "Дата и время прогона антиплагиата: " + DateTime.UtcNow;
var paraText = document.CreateTextNode(data);
p.AppendChild(paraText);
document.Body.AppendChild(p);

// Добавить упорядоченный список
// Создать элемент абзаца
var list = (HTMLOListElement)document.CreateElement("ol");

// Добавить элемент 1
var item1 = (HTMLLIElement)document.CreateElement("li");
item1.AppendChild(document.CreateTextNode("First list item."));

// Добавить пункт 2
var item2 = (HTMLLIElement)document.CreateElement("li");
item2.AppendChild(document.CreateTextNode("Second list item."));

// Добавить li элементы в список
list.AppendChild(item1);
list.AppendChild(item2);

// Прикрепить список к телу документа 
document.Body.AppendChild(list);

// Сохраните документ HTML в файл 
document.Save(@"C:\Users\100ma\Desktop\Fedor100ma\Стажировка\create-new-document.html");