//when i click on my button
document.getElementById('fillForm').addEventListener('click', function(){
    //grab the text filed value from my tool
    var intValue = document.getElementById('apivalue').value;

    chrome.tabs.executeScript({
        //send the value to be used by our script
        code: `var value = ${intValue};`
    }, function() {
        //run the script in the file injector.js
        chrome.tabs.executeScript({
            file: 'injector.js'
        });
    });
  });