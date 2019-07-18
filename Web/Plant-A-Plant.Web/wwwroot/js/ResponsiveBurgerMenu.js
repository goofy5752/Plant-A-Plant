$('#onLabel').on('click', function () {
    doWork();
});
function doWork() {
   
    if ($("#responsive").attr("imHidden") === "true") {
        $("#responsive").css(
                {
                    display: "block",
                    background: "#fd5c63",
                    padding: "15px 0",
                    "text-align": "center",
                    width: "100%",
                    "z-index": "999"
                });
        $("#responsive").attr('imHidden', 'false');
        } else {

            $("#responsive").css(
                {
                    display: "",
                    background: "",
                    padding: "",
                    "text-align": "",
                    width: "",
                    "z-index": ""
                });
            $("#responsive").attr('imHidden', 'true');
        }
  
}
   
