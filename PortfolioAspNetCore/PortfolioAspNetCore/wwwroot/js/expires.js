$("form").submit(function (e) {
	e.preventDefault();
	var article = $("input[name='article']").val();
	var dateOfExpiretis = $("input[name='dateOfExpiretis']").val();
	var description = $("input[name='description']").val();

	$.ajax({
		type: "POST",
		data: JSON.stringify({ Article: article, DateOfExpiretis: dateOfExpiretis, Description: description }),
		url: "/Admin/CreateExpiretis",
		dataType: 'json',
		contentType: "application/json; charset=utf-8",
		processData: false,
		success: function (response) {
			$(".data-table tbody").append(`<tr data-id='${response.id}' data-article='${response.article}' data-dateOfExpiretis='${response.dateOfExpiretis}' data-description='${response.description}'><td>${response.article}</td><td>${response.dateOfExpiretis}</td><td>${response.description}</td><td><button class='btn btn-info btn-xs btn-edit ml-20'>Edit</button><button class='btn btn-danger btn-xs btn-delete ml-20'>Delete</button></td></tr>`);
		},
		error: function (response) {
			if (response.Article === "") {
				alert("error!");
			}
		}
	})

	$("input[name='article']").val('');
	$("input[name='dateOfExpiretis']").val('');
	$("input[name='description']").val('');
});

$("body").on("click", ".btn-delete", function () {
	var id = $(this).parents("tr").attr('data-id');
	var element = this;
	$.ajax({
		type: "POST",
		data: JSON.stringify({ Id: id }),
		url: "/Admin/DeleteExpiretis",
		dataType: 'json',
		contentType: "application/json; charset=utf-8",
		processData: false,
		success: function (response) {
			console.log(response)
			if (response.id == id) {
				$(element).parents("tr").remove();
			}
		},
		error: function (response) {
			alert("error!");
		}
	})
});

$("body").on("click", ".btn-edit", function () {
	var article = $(this).parents("tr").attr('data-article');
	var dateOfExpiretis = $(this).parents("tr").attr('data-dateOfExpiretis');
	var description = $(this).parents("tr").attr('data-description');

	$(this).parents("tr").find("td:eq(0)").html('<input name="edit_article" value="' + article + '" required>');
	$(this).parents("tr").find("td:eq(1)").html('<input name="edit_dateOfExpiretis" value="' + dateOfExpiretis + '" required>');
	$(this).parents("tr").find("td:eq(2)").html('<input name="edit_description" value="' + description + '" required>');

	$(this).parents("tr").find("td:eq(3)").prepend("<button class='btn btn-info btn-xs btn-update ml-20'>Update</button><button class='btn btn-warning btn-xs btn-cancel ml-20'>Cancel</button>")
	$(this).hide();
});

$("body").on("click", ".btn-cancel", function () {
	var article = $(this).parents("tr").attr('data-article');
	var dateOfExpiretis = $(this).parents("tr").attr('data-dateOfExpiretis');
	var description = $(this).parents("tr").attr('data-description');

	$(this).parents("tr").find("td:eq(0)").text(article);
	$(this).parents("tr").find("td:eq(1)").text(dateOfExpiretis);
	$(this).parents("tr").find("td:eq(2)").text(description);

	$(this).parents("tr").find(".btn-edit").show();
	$(this).parents("tr").find(".btn-update").remove();
	$(this).parents("tr").find(".btn-cancel").remove();
});

$("body").on("click", ".btn-update", function () {
	const element = this;
	var id = $(element).parents("tr").attr('data-id');
	var article = $(element).parents("tr").find("input[name='edit_article']").val();
	var dateOfExpiretis = $(element).parents("tr").find("input[name='edit_dateOfExpiretis']").val();
	var description = $(element).parents("tr").find("input[name='edit_description']").val();
	$.ajax({
		type: "POST",
		data: JSON.stringify({ Id: id, Article: article, DateOfExpiretis: dateOfExpiretis, Description: description }),
		url: "/Admin/EditExpiretis",
		dataType: 'json',
		contentType: "application/json; charset=utf-8",
		processData: false,
		success: function (response) {
			if (response.id == id) {
				$(element).parents("tr").find("td:eq(0)").text(response.article);
				$(element).parents("tr").find("td:eq(1)").text(response.dateOfExpiretis);
				$(element).parents("tr").find("td:eq(2)").text(response.description);

				$(element).parents("tr").attr('data-article', response.article);
				$(element).parents("tr").attr('data-dateOfExpiretis', response.dateOfExpiretis);
				$(element).parents("tr").attr('data-description', response.description);
				$(element).parents("tr").find(".btn-edit").show();
				$(element).parents("tr").find(".btn-cancel").remove();
				$(element).parents("tr").find(".btn-update").remove();
			}
		},
		error: function (response) {
			alert("Слишком большие значение цифр");
		}
	})
});