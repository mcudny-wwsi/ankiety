$(document).ready(function () {
    initForm();
});

function initForm() {
    $("form").each(function () {
        var submit = $(this).find(".submit");
        var action = $(this).attr("action");
        var method = $(this).attr("method");

        $(".odp input").on("change", function (e) {
            if ($(this).attr("value") == 0) {
                $(this).attr("value",1);
            } else {
                $(this).attr("value",0);
            }
        })

        submit.click(function (e) {
            var values = [];
            var json = '';

            var len = $(".odp").length;
            $(".odp").each(function (e) {
                var me = $(this).find("input");
                var id = parseInt(me.attr("id").replace("odpowiedz-", ""));
                var val = me.attr("value");

                console.log(me);

                if (e === (len - 1)) {
                    json = json + val + '';
                } else {
                    json = json + val + ',';
                }
            })


                $.ajax({
                    url: action,
                    method: method,
                    data: { ankietaID: $("input[name='ankietaID']").val(), odpowiedzi: json }
                })
              .done(function (data) {
                  console.log("reload");
                  console.log(data);
                  //location.reload();
              });

            return false;
        })
    })
}