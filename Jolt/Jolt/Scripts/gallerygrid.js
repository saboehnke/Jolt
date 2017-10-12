$(document).ready(function()
{
	$('li img').on('click',function()
	{
		var src = $(this).attr('src');
		var img = '<img src="' + src + '" class="img-responsive"/>';
		$('#galleryModal').modal();
		$('#galleryModal').on('shown.bs.modal', function()
		{
			$('#galleryModal .modal-body').html(img);
		});
		$('#galleryModal').on('hidden.bs.modal', function()
		{
			$('#galleryModal .modal-body').html('');
		});
	});
})