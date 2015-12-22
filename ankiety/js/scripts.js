$(document).ready(function () {
    initForm();
});

function initForm() {
    $("form").each(function () {
        var submit = $(this).find(".submit");
        var action = $(this).attr("action");
        var method = $(this).attr("method");

        $("input[type='checkbox']").on("change", function (e) {
            if ($(this).attr("value") == 0) {
                $(this).attr("value",1);
            } else {
                $(this).attr("value",0);
            }
        })

        submit.click(function (e) {
            var values = [];
            var json = "{";

            var len = $("input[type='checkbox']").length;
            $("input[type='checkbox']").each(function (e) {
                var id = parseInt($(this).attr("id").replace("odpowiedz-",""));
                var val = $(this).attr("value");

                if (e === (len - 1)) {
                    json = json + '"' + id + '":"' + val + '"';
                } else {
                    json = json + '"' + id + '":"' + val + '",';
                }
            })

            json = json + "}";

                $.ajax({
                    url: action,
                    method: method,
                    data: { ankietaID: $("input[name='ankietaID']").val(), odpowiedzi: json }
                })
              .done(function (data) {
                  console.log(data);
              });

            return false;
        })
    })
}